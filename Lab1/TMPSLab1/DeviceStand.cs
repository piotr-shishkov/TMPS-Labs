using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPSLab1.Devices;

namespace TMPSLab1
{
	public class DeviceStand
	{
		private List<Device> Devices;
		private static DeviceStand instance;

		private DeviceStand()
		{
			Devices = new List<Device>();
		}

		public static DeviceStand GetInstance()
		{
			if (instance == null)
			{
				instance = new DeviceStand();
			}
			return instance;
		}

		public void AddDevice(Device device)
		{
			Devices.Add(device);
		}

		public void RemoveDevice(Device device)
		{
			Devices.Remove(device);
		}

		public void PrintDevices()
		{
			foreach (var device in Devices)
			{
				Console.WriteLine($"\nManufacturer: {device.Manufacturer}" +
				                  $"\nModel: {device.Model}" +
				                  $"\nSerial Number: {device.SerialNumber}" +
				                  $"\nScreen Orientation: {device.ScreenOrientation}");	
			}
		}
	}
}
