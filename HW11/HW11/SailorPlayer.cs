using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class SailorPlayer
    {
        public string Name { get; set; }

        public int[,] SeaField { get; set; }

        public SailorPlayer(string name)
        {
            Name = name;
        }
    }
}
