using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPSLab1.Devices;

namespace TMPSLab1
{
	public abstract class DeviceBuilder
	{
		protected Device device;

		public DeviceBuilder()
		{
			device = new Device(0);
		}

		public DeviceBuilder SetSerialNumber(string serialNumber)
		{
			device.SerialNumber = serialNumber;
			return this;
		}

		public DeviceBuilder SetManufacturer(string manufacturer)
		{
			device.Manufacturer = manufacturer;
			return this;
		}

		public DeviceBuilder SetModel(string model)
		{
			device.Model = model;
			return this;
		}

		public Device CreateDevice()
		{
			return device;
		}
	}

	public class PhoneBuilder : DeviceBuilder
	{
		public PhoneBuilder()
		{
			device = new Phone();
		}
	}

	public class LaptopBuilder : DeviceBuilder
	{
		public LaptopBuilder()
		{
			device = new Laptop();
		}
	}
}
