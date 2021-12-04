using TMPSLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMPSLab2.Models
{
    class CrossScrewdriver : IScrewdriver
    {
        public int Size { get; set; }

        public void Apply()
        {
            Console.WriteLine($"Cross screwdriver of size {Size} was applied");
        }
    }
}
