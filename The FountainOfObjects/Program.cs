using System;
using The_FountainOfObjects;


Run();

void Run()
{
    Board _board = new Board();
    Player _player = new Player();
    Menu _menu = new Menu();
    bool _playerWon = false;
    string _getPlayerMove;
    Fountain _fountain = new Fountain();

    Console.Clear();

    while (!_playerWon)
    {
        string line0 = "----------------------------------------------------------------------------------";
        string line1 = $"You are in the room at ({_player.GetLocation()})";
        string line2 = getString2(_board, _player, _fountain);

        string message = line2 switch
        { 
        "" => $"{line0}\n{line1}",
        _ => $"{line0}\n{line1}\n{line2}"
        };

        Console.WriteLine(message);
        string nextMove = _menu.GetUserInput("What do you want to do? ");

        _playerWon = (isPlayerInEntrance(_player) && isFoutainOn(_fountain));
    }

}

bool isPlayerInFountainRoom(Board board, Player player)
{
    return board.Rooms[player.CurrentLocation.X, player.CurrentLocation.Y].HasFountain;
}

bool isFoutainOn(Fountain fountain)
{
    return fountain.FountainIsOn;
}

bool isPlayerInEntrance(Player player)
{
    Coordinate entranceCooridnates = new Coordinate(0, 0);
    return player.CurrentLocation.Equals(entranceCooridnates);
}

string getString2(Board board, Player player, Fountain fountain)
{
    if (isPlayerInFountainRoom(board, player) && isFoutainOn(fountain))
    {
        return "You hear rushing waters from the Fountain of Objects. It has been reactivated!";
    }
    else if (isPlayerInEntrance(player) && isFoutainOn(fountain))
    {
        return "The Fountain of Objects has been reactivated, and you have escaped with our life!";
    }
    else if (isPlayerInEntrance(player) && !isFoutainOn(fountain))
    {
        return "You see light coming from the cabin entrance.";
    }
    else return "";
}


