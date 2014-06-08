using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {

	public class Memory {
		public const uint MemorySize = 4096;
		public const ushort StartAddress = 0x200; // 200 hex = 512 bytes, this is where the Chip8 actually starts.

		// Graphics are drawn to the screen solely by drawing sprites,
		// which are 8 pixels wide and may be from 1 to 15 pixels in height.
		public static byte[] FontSet = {
			0xF0, 0x90, 0x90, 0x90, 0xF0, // 0
			0x20, 0x60, 0x20, 0x20, 0x70, // 1
			0xF0, 0x10, 0xF0, 0x80, 0xF0, // 2
			0xF0, 0x10, 0xF0, 0x10, 0xF0, // 3
			0x90, 0x90, 0xF0, 0x10, 0x10, // 4
			0xF0, 0x80, 0xF0, 0x10, 0xF0, // 5
			0xF0, 0x80, 0xF0, 0x90, 0xF0, // 6
			0xF0, 0x10, 0x20, 0x40, 0x40, // 7
			0xF0, 0x90, 0xF0, 0x90, 0xF0, // 8
			0xF0, 0x90, 0xF0, 0x10, 0xF0, // 9
			0xF0, 0x90, 0xF0, 0x90, 0x90, // A
			0xE0, 0x90, 0xE0, 0x90, 0xE0, // B
			0xF0, 0x80, 0x80, 0x80, 0xF0, // C
			0xE0, 0x90, 0x90, 0x90, 0xE0, // D
			0xF0, 0x80, 0xF0, 0x80, 0xF0, // E
			0xF0, 0x80, 0xF0, 0x80, 0x80  // F	
		};

		// The Chip 8 has 4K memory in total.
		// The systems memory map:
		//	0x000-0x1FF - Chip 8 interpreter (contains font set in emulator)
		//	0x050-0x0A0 - Used for the built in 4x5 pixel font set (0-F)
		//	0x200-0xFFF - Program ROM and work RAM
		private byte[] _memory = new byte[MemorySize]; // 4K

		// Stack to keep the program counter / location
		private Stack<ushort> _stack = new Stack<ushort>(16);

		public byte this[int address] {
			get {
				return _memory[address];
			}
			internal set {
				_memory[address] = value;
			}
		}

		public ushort[] Stack {
			get {
				return _stack.ToArray();
			}
		}

		public ushort GetValue(ushort address) {
			// The Chip 8 has 35 opcodes which are all two bytes long
			return (ushort)((_memory[address] << 8) | _memory[address + 1]);
		}

		public ushort GetValue(int address) {
			// The Chip 8 has 35 opcodes which are all two bytes long
			return (ushort)((_memory[address] << 8) | _memory[address + 1]);
		}

		public ushort Pop() {
			return _stack.Pop();
		}

		public void Push(ushort value) {
			_stack.Push(value);
		}

		public void Reset(string romFile) {
			if (File.Exists(romFile)) {

				// clear the stack
				_stack.Clear();

				// Clear memory
				for (int i = 0; i < _memory.Length; ++i) {
					_memory[i] = 0;
				}

				// Unfortunate type casting here
				using (BinaryReader reader = new BinaryReader(File.Open(romFile, FileMode.Open))) {
					int fileSize = (int)reader.BaseStream.Length;

					byte[] buffer = new byte[fileSize];
					reader.Read(buffer, 0, fileSize);

					if ((MemorySize - 512) > fileSize) {
						for (int i = 0; i < fileSize; i++) {
							_memory[i + 512] = buffer[i];
						}
					} else {
						throw new Exception("ROM file too big for memory.");
					}
				}

				// Load Font
				// This fontset should be loaded in memory location 0x50 == 80 and onwards
				for (int i = 0; i < FontSet.Length; i++) {
					_memory[i] = FontSet[i];
				}
			} else {
				throw new Exception("ROM file does not exist.");
			}
		}

		public string Disassemble() {
			List<string> asm = new List<string>();

			for (int i = StartAddress; i < _memory.Length - 1; i++) {

				ushort opcode = (ushort)((_memory[i] << 8) | _memory[i + 1]);
				switch (opcode & 0xF000) { // extract the 1st nibble by using a bitwise "and" with 0.
					case 0x0000: {
							switch (opcode & 0x00FF) { // extract the last byte
								case 0x00E0: { // 0x00E0 -> Clears the screen.
										asm.Add("CLS");
										break;
									}
								case 0x00EE: { // 0x00EE -> Returns from a subroutine.
										asm.Add("RTS");
										break;
									}
								default: { // 0x0NNN -> Calls RCA-1802 program at address NNN.
										// NOTE: Not applicable to the Emulator
										//int NNN = (opcode & 0x0FFF);
										//asm.Add(String.Format("SYS &{0:X}", NNN));
										break;
									}
							}
							break;
						}
					case 0x1000: { // 0x1NNN -> Jumps to address NNN.
							int NNN = (opcode & 0x0FFF);
							asm.Add(String.Format("JMP &{0:X}", NNN));
							break;
						}
					case 0x2000: { // 0x2NNN -> Calls subroutine at NNN.
							int NNN = (opcode & 0x0FFF);
							asm.Add(String.Format("CALL &{0:X}", NNN));
							break;
						}
					case 0x3000: { // 0x3XNN -> Skips the next instruction if VX equals NN. (VX == NN)
							int VX = ((opcode & 0x0F00) >> 8);
							int NN = (opcode & 0x00FF);
							asm.Add(String.Format("SKEQ V{0}, 0x{1:X}", VX, NN));
							break;
						}
					case 0x4000: { // 0x4XNN -> Skips the next instruction if VX doesn't equal NN. (VX != NN)
							int VX = ((opcode & 0x0F00) >> 8);
							int NN = (opcode & 0x00FF);
							asm.Add(String.Format("SKNE V{0}, 0x{1:X}", VX, NN));
							break;
						}
					case 0x5000: { // 0x5XY0 -> Skips the next instruction if VX equals VY. (VX == VY)
							int VX = ((opcode & 0x0F00) >> 8);
							int VY = ((opcode & 0x00F0) >> 4);
							asm.Add(String.Format("SKEQ V{0}, V{1}", VX, VY));
							break;
						}
					case 0x6000: { // 0x6XNN -> Sets VX to NN.
							int VX = ((opcode & 0x0F00) >> 8);
							int NN = (opcode & 0x00FF);
							asm.Add(String.Format("MVI V{0}, 0x{1:X}", VX, NN));
							break;
						}
					case 0x7000: { // 0x7XNN -> Adds NN to VX.
							int VX = ((opcode & 0x0F00) >> 8);
							int NN = (opcode & 0x00FF);
							asm.Add(String.Format("ADI V{0}, 0x{1:X}", VX, NN));
							break;
						}
					case 0x8000: {
							int VX = ((opcode & 0x0F00) >> 8);
							int VY = ((opcode & 0x00F0) >> 4);
							switch (opcode & 0x000F) { // extract the last nibble
								case 0x0000: { // 0x8XY0 -> Sets VX to the value of VY.
										asm.Add(String.Format("MOV V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0001: { // 0x8XY1 -> Sets VX to VX or VY.
										asm.Add(String.Format("OR V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0002: { // 0x8XY2 -> Sets VX to VX and VY.
										asm.Add(String.Format("AND V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0003: { // 0x8XY3 -> Sets VX to VX xor VY.
										asm.Add(String.Format("XOR V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0004: { // 0x8XY4 -> Adds VY to VX. VF is set to 1 when there's a carry, and to 0 when there isn't.
										asm.Add(String.Format("ADD V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0005: { // 0x8XY5 -> VY is subtracted from VX. VF is set to 0 when there's a borrow, and 1 when there isn't.
										asm.Add(String.Format("SUB V{0}, V{1}", VX, VY));
										break;
									}
								case 0x0006: { // 0x8XY6 -> Shifts VX right by one. VF is set to the value of the least significant bit of VX before the shift.
										asm.Add(String.Format("SHR V{0}", VX));
										break;
									}
								case 0x0007: { // 0x8XY7 -> Sets VX to VY minus VX. VF is set to 0 when there's a borrow, and 1 when there isn't.
										asm.Add(String.Format("SUB V{0}, V{1} - V{0}", VX, VY));
										break;
									}
								case 0x0008: { // 0x8XYE -> Shifts VX left by one. VF is set to the value of the most significant bit of VX before the shift.
										asm.Add(String.Format("SHL V{0}", VX));
										break;
									}
							}
							break;
						}
					case 0x9000: { // 0x9XY0 -> Skips the next instruction if VX doesn't equal VY. (VX != VY)
							int VX = ((opcode & 0x0F00) >> 8);
							int VY = ((opcode & 0x00F0) >> 4);
							asm.Add(String.Format("SKNE V{0}, V{1}", VX, VY));
							break;
						}
					case 0xA000: { // 0xANNN -> Sets I to the address NNN.
							int NNN = (opcode & 0x0FFF);
							asm.Add(String.Format("MVI I, &{0:X}", NNN));
							break;
						}
					case 0xB000: { // 0xBNNN -> Jumps to the address NNN plus V0.
							int NNN = (opcode & 0x0FFF);
							asm.Add(String.Format("JMP &{0:X} + V0", NNN));
							break;
						}
					case 0xC000: { // 0xCXNN -> Sets VX to a random number and NN.
							int VX = ((opcode & 0x0F00) >> 8);
							int NN = (opcode & 0x00FF);
							asm.Add(String.Format("RND V{0}, 0x{1:X}", VX, NN));
							break;
						}
					case 0xD000: { // 0xDXYN -> Draws a sprite at coordinate (VX, VY) that has a width of 8 pixels and a height of N pixels.
							int VX = ((opcode & 0x0F00) >> 8);
							int VY = ((opcode & 0x00F0) >> 4);
							int N = (opcode & 0x000F);
							asm.Add(String.Format("DRW V{0}, V{1}, 0x{2:X}", VX, VY, N));
							break;
						}
					case 0xE000: {
							int VX = ((opcode & 0x0F00) >> 8);
							switch (opcode & 0x00FF) { // extract the last byte
								case 0x009E: { // 0xEX9E -> Skips the next instruction if the key stored in VX is pressed.
										asm.Add(String.Format("SKPKEY.Y V{0}", VX));
										break;
									}
								case 0x00A1: { // 0xEXA1 -> Skips the next instruction if the key stored in VX isn't pressed.
										asm.Add(String.Format("SKPKEY.N V{0}", VX));
										break;
									}
							}
							break;
						}
					case 0xF000: {
							int VX = ((opcode & 0x0F00) >> 8);
							switch (opcode & 0x00FF) { // extract the last byte
								case 0x0007: { // 0xFX07 -> Sets VX to the value of the delay timer.
										asm.Add(String.Format("MOV V{0}, DELAY", VX));
										break;
									}
								case 0x000A: { // 0xFX0A -> A key press is awaited, and then stored in VX.
										asm.Add(String.Format("KEY V{0}", VX));
										break;
									}
								case 0x0015: { // 0xFX15 -> Sets the delay timer to VX.
										asm.Add(String.Format("DELAY V{0}", VX));
										break;
									}
								case 0x0018: { // 0xFX18 -> Sets the sound timer to VX.
										asm.Add(String.Format("SOUND V{0}", VX));
										break;
									}
								case 0x001E: { // 0xFX1E -> Adds VX to I.
										asm.Add(String.Format("ADI V{0}", VX));
										break;
									}
								case 0x0029: { // 0xFX29 -> Sets I to the location of the sprite for the character in VX. Characters 0-F (in hexadecimal) are represented by a 4x5 font.
										asm.Add(String.Format("FONT V{0}", VX));
										break;
									}
								case 0x0033: { // 0xFX33 -> Stores the Binary-coded decimal representation of VX.
										asm.Add(String.Format("BCD V{0}", VX));
										break;
									}
								case 0x0055: { // 0xFX55 -> Stores V0 to VX in memory starting at address I.
										asm.Add(String.Format("STR V0, V{0}, &I", VX));
										break;
									}
								case 0x0065: { // 0xFX65 -> Fills V0 to VX with values from memory starting at address I.
										asm.Add(String.Format("LDR V0, V{0}, &I", VX));
										break;
									}
							}
							break;
						}
					default: {
							asm.Add("[UNK]");
							break;
						}
				}
			}

			return string.Join("\n", asm.ToArray());
		}
	}
}
