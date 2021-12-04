using TMPSLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using TMPSLab2.Devices;

namespace TMPSLab2.Models
{
    class Cpu : Detail
    {
        public float Frequency { get; set; }
        public int CoreNumber { get; set; }

        public Cpu(IDetailApi detailApi) : base(detailApi) { }

        public override void Install(Device device)
        {
            device.CpuFrequency = Frequency;
            detailApi.Install(device, this);
        }

        public override string ToString()
        {
            return $"Cpu: Frequency - {Frequency} GHz; CoreNumber - { CoreNumber };";
        }
    }
}
