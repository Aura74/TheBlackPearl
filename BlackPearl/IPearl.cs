using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearl
{
    internal interface IPearl : IEquatable<IPearl>, IComparable<IPearl>
    {
        public int Diameter { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public void RandomInit();
    }
}
