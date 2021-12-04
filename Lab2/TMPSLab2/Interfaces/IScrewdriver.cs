using System;
using System.Collections.Generic;
using System.Text;

namespace TMPSLab2.Interfaces
{
    interface IScrewdriver
    {
        public int Size { get; set; }

        public void Apply();
    }
}
