using TMPSLab2.Interfaces;
using System;
using TMPSLab2.Devices;

namespace TMPSLab2.Models
{
    class DualCoreCpu : IDetailApi
    {
        public void Install(Device device, Detail detail)
        {
            Console.WriteLine($"Installing new DualCore CPU in {device.Model}. {detail}");
        }
    }
}
