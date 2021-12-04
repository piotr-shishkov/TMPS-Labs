using TMPSLab2.Models;
using TMPSLab2.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TMPSLab2.FlyWeights
{
    class ScrewdriverFactory
    {
        private static readonly Dictionary<string, IScrewdriver> screwdrivers = new Dictionary<string, IScrewdriver>();

        public static IScrewdriver GetScrewdriver(string type)
        {
            bool found = screwdrivers.TryGetValue(type, out IScrewdriver screwdriver);

            if (!found)
            {
                switch (type)
                {
                    case "flat": screwdrivers.Add(type, new FlatScrewdriver()); break;
                    case "cross": screwdrivers.Add(type, new CrossScrewdriver()); break;
                }

                screwdrivers.TryGetValue(type, out screwdriver);
            }

            return screwdriver;
        }
    }
}
