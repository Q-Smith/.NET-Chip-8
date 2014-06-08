using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {

	// Input is done with a hex keyboard that has 16 keys which range from 0 to F.
	// The '8', '4', '6', and '2' keys are typically used for directional input.
	public class Keyboard {

		private byte[] _keys = new byte[16]; // 16 touches

		public byte this[int index] {
			get {
				return _keys[index];
			}
			set {
				_keys[index] = value;
			}
		}

		public void Reset() {
			for (int i = 0; i < _keys.Length; i++) {
				_keys[i] = 0;
			}
		}
	}
}
