using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPSLab1.Devices;

namespace TMPSLab1
{
	class Program
	{
		private static PhoneFactory phoneFactory;
		private static LaptopFactory laptopFactory;

		static void Main(string[] args)
		{
			var deviceStand = DeviceStand.GetInstance();
			phoneFactory = new PhoneFactory();
			laptopFactory = new LaptopFactory();

			Console.Write("Enter amount of device on Device Stand: ");
			var deviceAmount = int.Parse(Console.ReadLine());

			Console.WriteLine("\nDevices Adding:");
			for (var i = 0; i < deviceAmount; i++)
			{
				Console.WriteLine("\nNew Device:");
				Console.Write("Type (phone/laptop): ");
				var type = Console.ReadLine();
				Console.Write("Manufacturer: ");
				var manufacturer = Console.ReadLine();
				Console.Write("Model: ");
				var model = Console.ReadLine();
				Console.Write("Serial Number: ");
				var serialNumber = Console.ReadLine();

				var newDevice = GetBuilderByType(type)
					.SetManufacturer(manufacturer)
					.SetModel(model)
					.SetSerialNumber(serialNumber)
					.CreateDevice();

				deviceStand.AddDevice(newDevice);
			}

			Console.WriteLine("\n\nYour Device Stand");
			Console.WriteLine("Devices:");
			deviceStand.PrintDevices();
			Console.ReadKey();
		}

		private static DeviceBuilder GetBuilderByType(string type)
		{
			if (type == "phone") return phoneFactory.GetDeviceBuilder();
			else return laptopFactory.GetDeviceBuilder();
		}
	}
}
