using System;
using System.Collections;
using System.Collections.Generic;

namespace Circuits {

	public class ACRailElm : RailElm {
		
		public ACRailElm(CirSim s) : base(WaveformType.AC, s) {
			
		}

	}
}