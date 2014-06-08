using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {

	// byte : 8-bits
	// ushort : 16-bits
	// uint : 32-bits
	public class Chip8Emulator {

		private Cpu _cpu;
		private Memory _memory;
		private Timers _timers;
		private Screen _screen;
		private Keyboard _keyboard;
		private Sound _sound;

		private bool _running = false;

		// There is a 16-bit Program Counter (pc) which can have a value from 0x000 to 0xFFF.
		private ushort _pc = Memory.StartAddress;

		public Cpu Cpu {
			get {
				return _cpu;
			}
		}

		public Memory Memory {
			get {
				return _memory;
			}
		}

		public bool IsRunning {
			get {
				return _running;
			}
		}

		public bool WaitingForInput {
			get {
				return false;
			}
		}

		public Chip8Emulator(Timers timers, Screen screen, Keyboard keyboard, Sound sound) {
			_cpu = new Cpu();
			_memory = new Memory();
			_timers = timers;
			_screen = screen;
			_keyboard = keyboard;
			_sound = sound;
		}

		public void LoadROM(string romFile) {
			// stop running
			_running = false;

			// reset the program counter
			_pc = Memory.StartAddress;

			// reset each component
			_cpu.Reset();
			_memory.Reset(romFile);
			_timers.Reset();
			_screen.Clear();
			_keyboard.Reset();
			_sound.Reset();

			Run();
		}

		public string Disassemble() {
			return _memory.Disassemble();
		}

		public void Run() {
			_running = true;
		}

		public void Pause() {
			_running = false;
		}

		public void KeyDown(byte key) {
			_keyboard[key] = 0x1;
		}

		public void KeyUp(byte key) {
			_keyboard[key] = 0x0;
		}

		public void Update() {
			if (!_running) {
				return;
			}

			for (int i = 0; i < Cpu.OperationPerSecond; i++) {
				ProcessOpCodes();
			}

			if (_timers.DelayTime > 0) {
				_timers.DelayTime--;
			}

			if (_timers.SoundTime > 0) {
				_timers.SoundTime--;
				if (_timers.SoundTime == 1) {
					_timers.SoundTime = 0;
					_sound.Beep();
				}
			}
		}

		public void Draw() {
			if (!_running) {
				return;
			}

			_screen.Render();
		}

		private void ProcessOpCodes() {
			// The Chip 8 has 35 opcodes which are all two bytes long
			// (extract the nibbles by using a bitwise "and" with 0)
			ushort opcode = _memory.GetValue(_pc);
			byte nibble4 = (byte)((opcode & 0xF000) >> 8);
			byte nibble3 = (byte)((opcode & 0x0F00) >> 8);
			byte nibble2 = (byte)((opcode & 0x00F0) >> 4);
			byte nibble1 = (byte)(opcode & 0x000F);

			switch (nibble4) {
				case 0x00: {
					switch (nibble1) {
						case 0x00: { // 0x00E0 -> Clears the screen.
							_screen.Clear();
							_screen.AllowDraw = true;
							_pc += 2;
							break;
						}
						case 0x0E: { // 0x00EE -> Returns from a subroutine.
							_pc = _memory.Pop();
							_pc += 2;
							break;
						}
						default: { // 0x0NNN -> Calls RCA-1802 program at address NNN.
							// NOTE: Not applicable to the Emulator
							break;
						}
					}
					break;
				}
				case 0x10: { // 0x1NNN -> Jumps to address NNN.
					ushort NNN = (ushort)(opcode & 0x0FFF);
					_pc = NNN;
					break;
				}
				case 0x20: { // 0x2NNN -> Calls subroutine at NNN.
					ushort NNN = (ushort)(opcode & 0x0FFF);
					_memory.Push(_pc);
					_pc = NNN;
					break;
				}
				case 0x30: { // 0x3XNN -> Skips the next instruction if VX equals NN. (VX == NN)
					ushort NN = (ushort)(opcode & 0x00FF);
					if (_cpu[nibble3] == NN) {
						_pc += 4;
					} else {
						_pc += 2;
					}
					break;
				}
				case 0x40: { // 0x4XNN -> Skips the next instruction if VX doesn't equal NN. (VX != NN)
					ushort NN = (ushort)(opcode & 0x00FF);
					if (_cpu[nibble3] != NN) {
						_pc += 4;
					} else {
						_pc += 2;
					}
					break;
				}
				case 0x50: { // 0x5XY0 -> Skips the next instruction if VX equals VY. (VX == VY)
					if (_cpu[nibble3] == _cpu[nibble2]) {
						_pc += 4;
					} else {
						_pc += 2;
					}
					break;
				}
				case 0x60: { // 0x6XNN -> Sets VX to NN.
					byte NN = (byte)(opcode & 0x00FF);
					_cpu[nibble3] = NN;
					_pc += 2;
					break;
				}
				case 0x70: { // 0x7XNN -> Adds NN to VX.
					byte NN = (byte)(opcode & 0x00FF);
					_cpu[nibble3] += NN;
					//_cpu[nibble3] = (byte)((_cpu[nibble3] + NN) & 0xFF);
					_pc += 2;
					break;
				}
				case 0x80: {
					switch (nibble1) {
						case 0x00: { // 0x8XY0 -> Sets VX to the value of VY.
							_cpu[nibble3] = _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x01: { // 0x8XY1 -> Sets VX to VX or VY.
							_cpu[nibble3] |= _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x02: { // 0x8XY2 -> Sets VX to VX and VY.
							_cpu[nibble3] &= _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x03: { // 0x8XY3 -> Sets VX to VX xor VY.
							_cpu[nibble3] ^= _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x04: { // 0x8XY4 -> Adds VY to VX. VF is set to 1 when there's a carry, and to 0 when there isn't.
							if (_cpu[nibble2] > (0xFF - _cpu[nibble3])) {
								_cpu[0xF] = 1; //carry
							} else {
								_cpu[0xF] = 0;
							}

							_cpu[nibble3] += _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x05: { // 0x8XY5 -> VY is subtracted from VX. VF is set to 0 when there's a borrow, and 1 when there isn't.
							if (_cpu[nibble3] > _cpu[nibble2]) {
								_cpu[0xF] = 1;
							} else {
								_cpu[0xF] = 0; //borrow
							}

							_cpu[nibble3] -= _cpu[nibble2];
							_pc += 2;
							break;
						}
						case 0x06: { // 0x8XY6 -> Shifts VX right by one. VF is set to the value of the least significant bit of VX before the shift.
							_cpu[0xF] = (byte)(_cpu[nibble3] & 0x1);
							_cpu[nibble3] >>= 1;
							_pc += 2;
							break;
						}
						case 0x07: { // 0x8XY7 -> Sets VX to VY minus VX. VF is set to 0 when there's a borrow, and 1 when there isn't.
							if (_cpu[nibble3] > _cpu[nibble2]) { // VY-VX
								_cpu[0xF] = 0; // there is a borrow
							} else {
								_cpu[0xF] = 1;
							}
							_cpu[nibble3] = (byte)(_cpu[nibble2] - _cpu[nibble3]);
							_pc += 2;
							break;
						}
						case 0x0E: { // 0x8XYE -> Shifts VX left by one. VF is set to the value of the most significant bit of VX before the shift.
							_cpu[0xF] = (byte)(_cpu[nibble3] >> 7);
							_cpu[nibble3] <<= 1;
							_pc += 2;
							break;
						}
					}
					break;
				}
				case 0x90: { // 0x9XY0 -> Skips the next instruction if VX doesn't equal VY. (VX != VY)
					if (_cpu[nibble3] != _cpu[nibble2]) {
						_pc += 4;
					} else {
						_pc += 2;
					}
					break;
				}
				case 0xA0: { // 0xANNN -> Sets I to the address NNN.
					ushort NNN = (ushort)(opcode & 0x0FFF);
					_cpu.IndexRegister = NNN;
					_pc += 2;
					break;
				}
				case 0xB0: { // 0xBNNN -> Jumps to the address NNN plus V0.
					ushort NNN = (ushort)(opcode & 0x0FFF);
					_pc = (ushort)(NNN + _cpu[0]);
					break;
				}
				case 0xC0: { // 0xCXNN -> Sets VX to a random number and NN.
					Random rand = new Random();
					byte NN = (byte)(opcode & 0x00FF);
					//_cpu[nibble3] = (byte)((rand.Next(0, 255) % 0xFF) & NN);
					_cpu[nibble3] = (byte)(rand.Next(0, 255) & NN);
					_pc += 2;
					break;
				}
				case 0xD0: { // 0xDXYN -> Draws a sprite at coordinate (VX, VY) that has a width of 8 pixels and a height of N pixels.
					ushort I = _cpu.IndexRegister;
					ushort VX = _cpu[nibble3];
					ushort VY = _cpu[nibble2];
					byte height = (byte)(opcode & 0x000F);
					byte[] sprite = new byte[height];

					// Get the sprite
					// Each row of 8 pixels is read as bit-coded (with the most significant bit of each byte displayed on the left) starting from memory location I.
					for (int index = 0; index < height; index++) {
						ushort result = (ushort)(I + index);
						sprite[index] = _memory[result];
					}

					// Create the Sprite
					_cpu[0xF] = 0; // initialize VF register
					bool collision = _screen.DrawSprite(VX, VY, sprite);
					if (collision) {
						_cpu[0xF] = 1;
					}

					_screen.AllowDraw = true;
					_pc += 2;
					break;
				}
				case 0xE0: {
					ushort lastbyte = (ushort)(opcode & 0x00FF);
					switch (lastbyte) {
						case 0x9E: { // 0xEX9E -> Skips the next instruction if the key stored in VX is pressed.
							byte key = _cpu[nibble3];
							if (_keyboard[key] == 0x1) {
								_pc += 4;
							} else {
								_pc += 2;
							}
							break;
						}
						case 0xA1: { // 0xEXA1 -> Skips the next instruction if the key stored in VX isn't pressed.
							byte key = _cpu[nibble3];
							if (_keyboard[key] == 0x0) {
								_pc += 4;
							} else {
								_pc += 2;
							}
							break;
						}
					}
					break;
				}
				case 0xF0: {
					ushort lastbyte = (ushort)(opcode & 0x00FF);
					switch (lastbyte) {
						case 0x07: { // 0xFX07 -> Sets VX to the value of the delay timer.
							_cpu[nibble3] = _timers.DelayTime;
							_pc += 2;
							break;
						}
						case 0x0A: { // 0xFX0A -> A key press is awaited, and then stored in VX.
							bool waitForKey = true;
							for (byte i = 0; i < 16; i++) {
								if (_keyboard[i] == 0x1) {
									//_cpu[nibble3] = _keyboard[i];
									_cpu[nibble3] = i;
									waitForKey = false;
									break;
								}
							}

							if (waitForKey) {
								break;
							}

							_pc += 2;
							break;
						}
						case 0x15: { // 0xFX15 -> Sets the delay timer to VX.
							_timers.DelayTime = _cpu[nibble3];
							_pc += 2;
							break;
						}
						case 0x18: { // 0xFX18 -> Sets the sound timer to VX.
							_timers.SoundTime = _cpu[nibble3];
							_pc += 2;
							break;
						}
						case 0x1E: { // 0xFX1E -> Adds VX to I.
							// VF is set to 1 when range overflow (I+VX>0xFFF), and 0 when there isn't.
							// This is undocumented feature of the Chip-8 game.
							if ((_cpu.IndexRegister + _cpu[nibble3]) > 0xFFF) {
								_cpu[0xF] = 1;
							} else {
								_cpu[0xF] = 0;
							}
							_cpu.IndexRegister += _cpu[nibble3];
							_pc += 2;
							break;
						}
						case 0x29: { // 0xFX29 -> Sets I to the location of the sprite for the character in VX. Characters 0-F (in hexadecimal) are represented by a 4x5 font.
							_cpu.IndexRegister = (ushort)(_cpu[nibble3] * 0x5);
							_pc += 2;
							break;
						}
						case 0x33: { // 0xFX33 -> Stores the Binary-coded decimal representation of VX.
							ushort I = _cpu.IndexRegister;
							_memory[I] = (byte)(_cpu[nibble3] / 100);
							_memory[I + 1] = (byte)((_cpu[nibble3] % 100) / 10);
							_memory[I + 2] = (byte)((_cpu[nibble3] % 100) % 10);
							_pc += 2;
							break;
						}
						case 0x55: { // 0xFX55 -> Stores V0 to VX in memory starting at address I.
							ushort I = _cpu.IndexRegister;
							for (byte i = 0; i <= nibble3; i++) {
								_memory[I + i] = _cpu[i];
							}
							_pc += 2;
							break;
						}
						case 0x65: { // 0xFX65 -> Fills V0 to VX with values from memory starting at address I.
							ushort I = _cpu.IndexRegister;
							for (byte i = 0; i <= nibble3; i++) {
								_cpu[i] = _memory[I + i];
							}
							_cpu.IndexRegister += (ushort)(nibble3 + 1);
							_pc += 2;
							break;
						}
					}
					break;
				}
			}
		}
	}
}
