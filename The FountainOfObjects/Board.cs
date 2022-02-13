using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    class Board : IBoard
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public Room[,] Rooms { get; set; }


        public Board()
        {
            SetSize();
            CreateRooms();
            SetFountainRoom();
        }
        public void SetFountainRoom()
        {
            Coordinate fountainRoom = new Coordinate(new Random().Next(0, NumberOfColumns), new Random().Next(0, NumberOfRows));
            Rooms[fountainRoom.X, fountainRoom.Y].HasFountain = true;
        }

        public void SetSize()
        {
            Menu menu = new Menu();
            string message = $"Choose a board size: small, medium, or large";
            string boardSizeSelected = menu.GetUserInput(message);
            BoardSize boardSize;
            while(!Enum.TryParse(boardSizeSelected, true, out boardSize))
            {
                Console.WriteLine("Invalid Input. Try again.");
                boardSizeSelected = menu.GetUserInput(message);
            }
            NumberOfColumns = NumberOfRows = boardSize switch
            {
                BoardSize.Small => 4,
                BoardSize.Medium => 6,
                BoardSize.Large => 8,
                _ => 4
            };
        }

        public void CreateRooms()
        {
            Rooms = new Room[NumberOfColumns, NumberOfRows];

            int i = 0;
            while (i < Rooms.GetLength(0))
            {
                int j = 0;
                while (j < Rooms.GetLength(1))
                {
                    Rooms[i, j] = new Room();
                    j++;
                }
                i++;
            }
        }
    }
}
