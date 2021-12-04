using System;
using System.Collections.Generic;
using System.Text;
using TMPSLab2.Devices;
using TMPSLab2.Models;

namespace TMPSLab2.Interfaces
{
    abstract class Detail
    {
        public readonly IDetailApi detailApi;

        public Detail(IDetailApi detailApi)
        {
            this.detailApi = detailApi;
        }

        public abstract void Install(Device device);

        public abstract override string ToString();
    }
}
