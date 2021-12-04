using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab2.Devices
{
	public abstract class DeviceFactory
	{
		public abstract DeviceBuilder GetDeviceBuilder();
	}

	public class PhoneFactory : DeviceFactory
	{
		public override DeviceBuilder GetDeviceBuilder()
		{
			return new PhoneBuilder();
		}
	}

	public class LaptopFactory : DeviceFactory
	{
		public override DeviceBuilder GetDeviceBuilder()
		{
			return new LaptopBuilder();
		}
	}
}
