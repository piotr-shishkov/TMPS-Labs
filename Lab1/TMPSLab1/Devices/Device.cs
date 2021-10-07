using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab1.Devices
{
	public class Device
	{
		public string SerialNumber { get; set; }
		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public readonly OrientationType ScreenOrientation;

		public Device(OrientationType orientationType)
		{
			ScreenOrientation = orientationType;
		}
	}

	public enum OrientationType
	{
		Vertical = 0,
		Horizontal = 1
	}
}
