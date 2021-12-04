using System;
using System.Collections.Generic;
using System.Text;

namespace TMPSLab2.Models
{
    class OctaCoreCpu : Cpu
    {
        private Cpu _cpu;

        public float FrequencyBoost { get; set; }

        public OctaCoreCpu(Cpu cpu): base(cpu.detailApi)
        {
            this._cpu = cpu;
            FrequencyBoost = 2.5f;
        }

        public override string ToString()
        {
            return _cpu.ToString() + $" Boost - {FrequencyBoost};";
        }
    }
}
