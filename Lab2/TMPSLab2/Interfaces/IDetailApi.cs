using TMPSLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using TMPSLab2.Devices;
using TMPSLab2.Models;

namespace TMPSLab2.Interfaces
{
    interface IDetailApi
    {
        public void Install(Device device, Detail detail);
    }
}
