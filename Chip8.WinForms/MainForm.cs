using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emulator.WinForms {

	public partial class MainForm : Form {

		private bool _glContextLoaded = false;
		private string _romfile = String.Empty;

		private Chip8Emulator _chip8;

		public MainForm(Chip8Emulator chip8) {
			_chip8 = chip8;
			InitializeComponent();
		}

		#region program Commands

		private void LoadAndReset() {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select a Chip-8 ROM File";
			openFileDialog.DefaultExt = "ch8";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Filter = "Chip-8 ROM (*.ch8)|*.ch8|Chip-8 ROM (*.c8k)|*.c8k|Chip-8 ROM (*.c8)|*.c8|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;

			if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
				_romfile = openFileDialog.FileName;
				_chip8.LoadROM(_romfile);

				this.Text = "Chip-8: " + Path.GetFileName(_romfile);

				NotifyToolbar();
				ClearControls();
				ShowASM();
			}
		}

		private void ClearControls() {
			lstbStack.Items.Clear();
			rtbMemoryBytes.Clear();
			rtbASM.Clear();
		}

		private void UpdateAndDraw() {
			_chip8.Update();
			DebugCpu();
			DebugMemory();

			if (tabContainer.SelectedTab == tabGame) {
				otkGLGame.MakeCurrent();
				_chip8.Draw();
				otkGLGame.SwapBuffers();
			} else if (tabContainer.SelectedTab == tabFontSet) {
				otkGLFontSet.MakeCurrent();
				DrawFontSet();
				otkGLFontSet.SwapBuffers();
			}
		}

		private void DebugCpu() {
			txtVI.Text = String.Format("0x{0:X}", _chip8.Cpu.IndexRegister);
			txtV0.Text = String.Format("0x{0:X}", _chip8.Cpu[0x0]);
			txtV1.Text = String.Format("0x{0:X}", _chip8.Cpu[0x1]);
			txtV2.Text = String.Format("0x{0:X}", _chip8.Cpu[0x2]);
			txtV3.Text = String.Format("0x{0:X}", _chip8.Cpu[0x3]);
			txtV4.Text = String.Format("0x{0:X}", _chip8.Cpu[0x4]);
			txtV5.Text = String.Format("0x{0:X}", _chip8.Cpu[0x5]);
			txtV6.Text = String.Format("0x{0:X}", _chip8.Cpu[0x6]);
			txtV7.Text = String.Format("0x{0:X}", _chip8.Cpu[0x7]);
			txtV8.Text = String.Format("0x{0:X}", _chip8.Cpu[0x8]);
			txtV9.Text = String.Format("0x{0:X}", _chip8.Cpu[0x9]);
			txtVA.Text = String.Format("0x{0:X}", _chip8.Cpu[0xA]);
			txtVB.Text = String.Format("0x{0:X}", _chip8.Cpu[0xB]);
			txtVC.Text = String.Format("0x{0:X}", _chip8.Cpu[0xC]);
			txtVD.Text = String.Format("0x{0:X}", _chip8.Cpu[0xD]);
			txtVE.Text = String.Format("0x{0:X}", _chip8.Cpu[0xE]);
			txtVF.Text = String.Format("0x{0:X}", _chip8.Cpu[0xF]);
		}

		private void DebugMemory() {
			// Stack
			ushort[] stack = _chip8.Memory.Stack;

			if (stack.Length != lstbStack.Items.Count) {
				lstbStack.Items.Clear();
				for (int i = 0; i < stack.Length; i++) {
					lstbStack.Items.Add(String.Format("0x{0:X}", stack[i]));
				}
			}

			// Memory
			if (rtbMemoryBytes.Text == String.Empty) {
				string stringMem = "Offset   00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F\n";
				for (int i = 0; i < Memory.MemorySize; i++) {
					if (i % 16 == 0 || i == 0) {
						stringMem += "\n";
						stringMem += String.Format("{0:X8} ", i);
						string val = String.Format("{0:X2} ", _chip8.Memory[i]);
						stringMem += val;
					} else
						stringMem += String.Format("{0:X2} ", _chip8.Memory[i]);
				}

				this.rtbMemoryBytes.Text = stringMem;
			}
		}

		private void ShowASM() {
			rtbASM.Text = _chip8.Disassemble();
		}

		private void Application_Idle(object sender, EventArgs e) {
			while (otkGLGame.IsIdle && _chip8.IsRunning && !_chip8.WaitingForInput) {
				UpdateAndDraw();
				Thread.Sleep(Timers.WaitTime);
			}
		}

		#endregion

		#region OpenGL Commands

		private void otkGLControl_Load(object sender, EventArgs e) {
			_glContextLoaded = true;

			GL.ClearColor(Color.Black);
			SetupViewport();

			Application.Idle += new EventHandler(Application_Idle);
		}

		private void otkGLControl_Resize(object sender, EventArgs e) {
			if (!_glContextLoaded) {
				return;
			}

			SetupViewport();
			if (tabContainer.SelectedTab == tabGame) {
				otkGLGame.Invalidate();
			} else if (tabContainer.SelectedTab == tabFontSet) {
				otkGLFontSet.Invalidate();
			}
		}

		private void otkGLControl_Paint(object sender, PaintEventArgs e) {
			if (!_glContextLoaded) {
				return;
			}

			UpdateAndDraw();
		}

		private void otkGLControl_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.NumPad1: { _chip8.KeyDown(0x1); break; }
				case Keys.NumPad2: { _chip8.KeyDown(0x2); break; }
				case Keys.NumPad3: { _chip8.KeyDown(0x3); break; }
				case Keys.NumPad4: { _chip8.KeyDown(0xC); break; }

				case Keys.Q: { _chip8.KeyDown(0x4); break; }
				case Keys.W: { _chip8.KeyDown(0x5); break; }
				case Keys.E: { _chip8.KeyDown(0x6); break; }
				case Keys.R: { _chip8.KeyDown(0xD); break; }

				case Keys.A: { _chip8.KeyDown(0x7); break; }
				case Keys.S: { _chip8.KeyDown(0x8); break; }
				case Keys.D: { _chip8.KeyDown(0x9); break; }
				case Keys.F: { _chip8.KeyDown(0xE); break; }

				case Keys.Z: { _chip8.KeyDown(0xA); break; }
				case Keys.X: { _chip8.KeyDown(0x0); break; }
				case Keys.C: { _chip8.KeyDown(0xB); break; }
				case Keys.V: { _chip8.KeyDown(0xF); break; }
			}

			otkGLGame.Invalidate();
		}

		private void otkGLControl_KeyUp(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Escape: { _chip8.Pause(); break; }
				case Keys.Space: { _chip8.Run(); break; }
				case Keys.NumPad1: { _chip8.KeyUp(0x1); break; }
				case Keys.NumPad2: { _chip8.KeyUp(0x2); break; }
				case Keys.NumPad3: { _chip8.KeyUp(0x3); break; }
				case Keys.NumPad4: { _chip8.KeyUp(0xC); break; }

				case Keys.Q: { _chip8.KeyUp(0x4); break; }
				case Keys.W: { _chip8.KeyUp(0x5); break; }
				case Keys.E: { _chip8.KeyUp(0x6); break; }
				case Keys.R: { _chip8.KeyUp(0xD); break; }

				case Keys.A: { _chip8.KeyUp(0x7); break; }
				case Keys.S: { _chip8.KeyUp(0x8); break; }
				case Keys.D: { _chip8.KeyUp(0x9); break; }
				case Keys.F: { _chip8.KeyUp(0xD); break; }

				case Keys.Z: { _chip8.KeyUp(0xA); break; }
				case Keys.X: { _chip8.KeyUp(0x0); break; }
				case Keys.C: { _chip8.KeyUp(0xB); break; }
				case Keys.V: { _chip8.KeyUp(0xF); break; }
			}

			otkGLGame.Invalidate();
		}

		private void SetupViewport() {
			int width = otkGLGame.Width;
			int height = otkGLGame.Height;

			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
			GL.Ortho(0, width, height, 0, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
			GL.MatrixMode(MatrixMode.Modelview);
			GL.Viewport(0, 0, width, height); // Use all of the glControl painting area
		}

		private void DrawFontSet() {
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();

			GL.Color3(Color.FromArgb(0xFFFFFF));
			GL.Begin(BeginMode.Quads);
			
			int xcurr = 10;
			int ycurr = 10;
			int yoffset = 0;
			int xoffset = 0;

			for (int font = 0; font < Memory.FontSet.Length; font++) {

				yoffset = ycurr;
				for (int y = font; y < (font + 5); y++) {
					byte b = Memory.FontSet[y];

					xoffset = xcurr;
					for (int x = 7; x >= 0; x--) {
						if ((b & (0x1 << x)) != 0) {
							GL.Vertex2(xcurr + xoffset, yoffset);
							GL.Vertex2(xcurr + xoffset, yoffset + Sprite.Height);
							GL.Vertex2(xcurr + xoffset + Sprite.Width, yoffset + Sprite.Height);
							GL.Vertex2(xcurr + xoffset + Sprite.Width, yoffset);
						}
						xoffset += Sprite.Width;
					}

					yoffset += Sprite.Height;
				}

				if ((font + 1) % 4 != 0) {
					xcurr += 40;
				} else {
					xcurr = 10;
					ycurr += 50;
				}

				font += 4;
			}
			GL.End();
		}

		#endregion

		#region Menu Commands

		private void mnuOpenROM_Click(object sender, EventArgs e) {
			LoadAndReset();
		}

		private void mnuExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void mnuKeyboard_Click(object sender, EventArgs e) {
			// TODO: Show Virtual Keyboard
			MessageBox.Show("Not Implemented Yet!", "Chip-8 Emulator", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void mnuAbout_Click(object sender, EventArgs e) {
			MessageBox.Show("Version: 1.0.0\nWritten by: Quinn Smith.", "Chip-8 Emulator", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion

		#region Toolbar Commands

		private void NotifyToolbar() {
			if (_chip8.IsRunning) {
				tbarRun.Enabled = false;
				tbarPause.Enabled = true;
				tbarReset.Enabled = true;
			} else {
				tbarRun.Enabled = true;
				tbarPause.Enabled = false;
				tbarReset.Enabled = true;
			}
		}

		private void tbarRun_Click(object sender, EventArgs e) {
			_chip8.Run();
			NotifyToolbar();
		}

		private void tbarPause_Click(object sender, EventArgs e) {
			_chip8.Pause();
			NotifyToolbar();
		}

		private void tbarReset_Click(object sender, EventArgs e) {
			LoadAndReset();
		}

		#endregion

		#region Tab Control Commands

		private void tabContainer_SelectedIndexChanged(object sender, EventArgs e) {
			if (tabContainer.SelectedTab == tabGame) {
				otkGLGame.Focus();
				otkGLGame.Select();
			}
		}

		#endregion
	}
}
