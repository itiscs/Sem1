using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsGame
{
    class Menu
    {
        private string path="menu.txt";
        private List<string> meniItems = new List<string>();
        private int current = 0;

        public Menu()
        {            
            using (StreamReader stream = new StreamReader(path))
            {
                while(!stream.EndOfStream)
                    meniItems.Add(stream.ReadLine());
            }

        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            int locX = 35, locY = 6;
            for (int i = 0; i < meniItems.Count; i++)
            {
                if (i == current)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.SetCursorPosition(locX, locY);
                Console.Write(meniItems[i]);
                locY++;

            }

        }

        public void Show()
        {
            ConsoleKeyInfo userKey;
            bool menuRunning = true;
            Draw();

            while (menuRunning)
            {

                userKey = Console.ReadKey(true);

                switch(userKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        current = current > 0 ? current - 1 : current;
                        break;
                    case ConsoleKey.DownArrow:
                        current = current < meniItems.Count-1 ? current + 1 : current;
                        break;
                    case ConsoleKey.Enter:
                        if(current == meniItems.Count - 1)
                            menuRunning = false;
                        break;
                }

                Draw();
        
            }

        }






    }
}
