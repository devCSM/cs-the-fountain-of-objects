using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    class Player : IPlayer, IPlayerCommand
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public Coordinate CurrentLocation { get; set; }

        public Player()
        {
            X = Y = 0;
            CurrentLocation = new Coordinate(X,Y);
        }

        public void MovePlayer(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    {
                        Y--;
                    }
                    break;
                case Direction.South:
                    {
                        Y++;
                    }
                    break;
                case Direction.East:
                    {
                        X++;
                    }
                    break;
                case Direction.West:
                    {
                        X--;
                    }
                    break;

            }
        }
        public string GetLocation() 
        {
            return $"Row={X} Column={Y}";
        }
    }
}
