using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    public enum Direction { North, South, East, West }
    interface IPlayerCommand
    {
        public void MovePlayer(Direction direction);
    }
}
