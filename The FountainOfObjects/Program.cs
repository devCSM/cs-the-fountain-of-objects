using System;

Board _board = new Board();
bool _fountainEnabled = false;
Coordinate _currentLocation = new Coordinate(0, 0);
Coordinate _entrance = new Coordinate(0, 0);



do
{
    DisplayCurentLocation();
    Console.Write("What do you want to do? ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    string move = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
    switch (move)
    {
        case "move north":
            if (_currentLocation.Y > 0)
            {
                _currentLocation.Y--;
            }
            break;
        case "move south":
            if (_currentLocation.Y < 3)
            {
                _currentLocation.Y++;
            }
            break;
        case "move east":
            if (_currentLocation.X < 3)
            {
                _currentLocation.X++;
            }
            break;
        case "move west":
            if (_currentLocation.X > 0)
            {
                _currentLocation.X--;
            }
            break;
        case "enable fountain":
            _fountainEnabled = true;
            break;
        default:
            Console.WriteLine("Invalid Command.");
            break;
    }
} while (!((_fountainEnabled) && (_currentLocation.X == 0 && _currentLocation.Y == 0)));

DisplayCurentLocation();

void DisplayCurentLocation()
{
    string message = "";
    
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.WriteLine($"You are in the room at (Row={_currentLocation.Y}, Column={_currentLocation.X})");
    if (_currentLocation.X == 0 && _currentLocation.Y == 0 && !_fountainEnabled)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        message = "You see a light coming from the cavern entrance.";
    }
    else if (_currentLocation.X == 2 && _currentLocation.Y == 0 && !_fountainEnabled)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        message = "You hear water dripping in this room. The fountain of objects is here!";
    }
    else if (_currentLocation.X == 2 && _currentLocation.Y == 0 && _fountainEnabled)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        message = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
    }
    else if ((_fountainEnabled) && (_currentLocation.X == 0 && _currentLocation.Y == 0))
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        message = "The Fountain of Objects has been reactivated, and you escaped with your life! You win!";
    }

    if (!String.IsNullOrEmpty(message))
    {
        Console.WriteLine(message);
    }
    Console.ForegroundColor = ConsoleColor.White;
}

enum Direction { North, South, East, West }

public class Coordinate
{
    public int X;
    public int Y;

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Room
{
    public bool HasFountain = false;
}

public class Board
{
    public Room[,] rooms = new Room[4, 4];

    public Board()
    {
        for (int row = 0; row < rooms.GetLength(0); row++)
        {
            for (int column = 0; column < rooms.GetLength(1); column++)
            {
                rooms[row, column] = new Room();
            }
        }

        // identify the fountain room
        rooms[0, 2].HasFountain = true;
    }

    public bool GetIsFountainRoom(int x, int y)
    {
        return rooms[x, y].HasFountain;
    }

}

