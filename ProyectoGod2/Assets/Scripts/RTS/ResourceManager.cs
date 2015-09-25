using UnityEngine;
using System.Collections;

namespace RTS {
	
	public static class ResourceManager {


		public static float ScrollSpeed { 
			get { 
				return 12f;
			} 
		}
		public static float RotateSpeed { 
			get {
				return 100; 
			} 
		}
		public static int ScrollWidth {
			get {
				return 50;
			}
		}
		public static float RotateAmount { 
			get { 
				return 10; 
			} 
		}
		public static float MinCameraHeight {
			get {
				return 30;
			}
		}
		public static float MaxCameraHeight {
			get {
				return 35;
			}
		}

	}
}