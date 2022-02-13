using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FountainOfObjects
{
    class Menu : IMenu
    {
        public string GetUserInput(string message)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();

            return userInput;
        }
    }
}
