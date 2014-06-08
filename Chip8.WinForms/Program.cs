using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emulator.WinForms {

	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Timers timers = new Timers();
			Screen screen = new Screen();
			Keyboard keyboard = new Keyboard();
			Sound sound = new Sound();
			Chip8Emulator chip8 = new Chip8Emulator(timers, screen, keyboard, sound);
			Application.Run(new MainForm(chip8));
		}
	}
}
