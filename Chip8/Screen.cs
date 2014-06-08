using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {
	// The original implementation of the Chip-8 language used a 64x32-pixel monochrome display with this format:
	//		*********************
	//		* (0,0)		(63,0)  *
	//		* (0,31)	(63,31) *
	//		*********************
	public class Screen {

		public const int InternalWidth = 64;
		public const int InternalHeight = 32;
		public const int PixelScale = 8;
		public const int PixelWidth = 8;
		public const int PixelHeight = 8;

		private bool _allowDraw = true;
		private bool[][] _pixels = new bool[InternalWidth][];

		public bool AllowDraw {
			set {
				_allowDraw = value;
			}
		}

		public Screen() {
			for (int i = 0; i < InternalWidth; i++) {
				_pixels[i] = new bool[InternalHeight];
			}
		}

		public void Clear() {
			_allowDraw = false;

			for (int x = 0; x < InternalWidth; x++) {
				for (int y = 0; y < InternalHeight; y++) {
					_pixels[x][y] = false;
				}
			}
		}

		public bool DrawSprite(ushort coordx, ushort coordy, byte[] sprite) {
			bool collided = false;

			int x = 0;
			int y = 0;
			for (int k = 0; k < sprite.Length; k++) { // height
				y = (coordy + k) % Screen.InternalHeight;

				byte hex = sprite[k];
				byte offset = 7;

				for (byte b = 0; b < 8; b++) { // bit flag
					x = (coordx + b) % Screen.InternalWidth;

					if (((hex) & (0x1 << offset)) != 0) { // scan through the byte, one bit at the time
						if (_pixels[x][y]) {
							collided = true;
						}
						_pixels[x][y] ^= true;
					}
					offset--;
				}
			}

			return collided;
		}

		public void Render() {
			if (_allowDraw) {
				GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
				GL.MatrixMode(MatrixMode.Modelview);
				GL.LoadIdentity();

				for (int y = 0; y < InternalHeight; y++) {
					for (int x = 0; x < InternalWidth; x++) {
						if (_pixels[x][y]) {
							GL.Color3(Color.FromArgb(0xFFFFFF));
						} else {
							GL.Color3(Color.FromArgb(0x000000));
						}

						GL.Begin(BeginMode.Quads);
						GL.Vertex2((x * PixelScale), (y * PixelScale));
						GL.Vertex2((x * PixelScale), (y * PixelScale) + PixelHeight);
						GL.Vertex2((x * PixelScale) + PixelWidth, (y * PixelScale) + PixelHeight);
						GL.Vertex2((x * PixelScale) + PixelWidth, (y * PixelScale));
						GL.End();
					}
				}

				//_allowDraw = false;
			}
		}
	}
}
