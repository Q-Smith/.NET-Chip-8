using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {

	public class Timers {

		public const int WaitTime = 14;

		public byte DelayTime { get; set; }
		public byte SoundTime { get; set; }

		public void Reset() {
			DelayTime = 0;
			SoundTime = 0;
		}
	}
}
