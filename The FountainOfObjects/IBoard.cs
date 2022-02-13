using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    public enum BoardSize { Small, Medium, Large }
    interface IBoard
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }

        public Room[,] Rooms { get; set; }

        public void SetSize();
        public void SetFountainRoom();
        public void CreateRooms();
    }
}
