using TMPSLab2.Interfaces;
using System;
using TMPSLab2.Devices;

namespace TMPSLab2.Models
{
    class QuadCoreCpu : IDetailApi
    {
        public void Install(Device device, Detail detail)
        {
            Console.WriteLine($"Installing new QuadCore CPU in {device.Model}. {detail}");
        }
    }
}
