using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator {

	public class Cpu {
		public const int OperationPerSecond = 4; // 250 Hz which is: 1/250 = 4ms

		// The Chip 8 has 15 8-bit general purpose registers named V0,V1 up to VE.
		// The 16th register is used  for the "carry flag".
		private byte[] _RV = new byte[16];

		// There is an 16-bit Index register I.
		private ushort _RI = 0;

		public byte this[int index] {
			get {
				return _RV[index];
			}
			set {
				_RV[index] = value;
			}
		}

		public ushort IndexRegister {
			get {
				return _RI;
			}
			internal set {
				_RI = value;
			}
		}

		public void Reset() {
			// clear registers
			for (int i = 0; i < _RV.Length; i++) {
				_RV[i] = 0;
			}

			_RI = 0;
		}
	}
}
