using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;
            ConsoleKeyInfo userKey;

            int locationX = 0;
            int locationY = 0;

            int prevlocationX = 0;
            int prevlocationY = 0;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Clear();

            



            while(gameRunning)
            {

                userKey = Console.ReadKey(true);
                prevlocationX = locationX;
                prevlocationY = locationY;

                switch (userKey.Key)
                {
                    case ConsoleKey.Escape:
                        gameRunning = false;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (locationX > 0)
                            locationX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (locationX < Console.WindowWidth - 1)
                            locationX++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (locationY > 0)
                            locationY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (locationY < Console.WindowHeight - 1)
                            locationY++;
                        break;
                }

                Console.SetCursorPosition(prevlocationX, prevlocationY);
                Console.Write(" ");
                Console.SetCursorPosition(locationX, locationY);
                Console.Write("@");

            }





        }
    }
}
