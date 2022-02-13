using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    interface IPlayer
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public string GetLocation();
    }
}
