using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPSLab2.Devices;
using TMPSLab2.FlyWeights;
using TMPSLab2.Models;
using TMPSLab2.Singletones;

namespace TMPSLab2
{
	class Program
	{
		private static PhoneFactory phoneFactory;
		private static LaptopFactory laptopFactory;

		static void Main(string[] args)
		{
			//InputDevices();
            UseDetails();
		}

		private static void InputDevices()
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

        public static void UseDetails()
        {
            var stand = DeviceStand.GetInstance();
            var deviceFactory = new PhoneFactory();
            stand.AddDevice
            (
                deviceFactory.GetDeviceBuilder()
                .SetModel("Nexus")
                .SetManufacturer("Google")
                .SetSerialNumber("123JFCJ23R2")
                .CreateDevice()
            );

            var quadCoreCpu = new Cpu(new QuadCoreCpu());
            var dualCoreCpu = new Cpu(new DualCoreCpu());

            quadCoreCpu.Frequency = 4.2f;
            quadCoreCpu.CoreNumber = 4;
            quadCoreCpu.Install(stand.GetDevice("123JFCJ23R2"));


            dualCoreCpu.Frequency = 3.5f;
            dualCoreCpu.CoreNumber = 2;
            dualCoreCpu.Install(stand.GetDevice("123JFCJ23R2"));

            var octaCoreCpu = new OctaCoreCpu(quadCoreCpu);
            Console.WriteLine(octaCoreCpu);
            Console.WriteLine();

            // List of wrenchs required for some work in order in which they need to be used
            List<Tuple<string, int>> requiredTools = new List<Tuple<string, int>>(new Tuple<string, int>[] {
                new Tuple<string, int>("cross", 4),
                new Tuple<string, int>("cross", 8),
                new Tuple<string, int>("flat", 2),
                new Tuple<string, int>("flat", 16),
            });

            foreach (var requirement in requiredTools)
            {
                var tool = ScrewdriverFactory.GetScrewdriver(requirement.Item1);
                tool.Size = requirement.Item2;
                tool.Apply();
            }

            Console.ReadKey();
        }
    }
}
