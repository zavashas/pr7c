using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Menu
    {
        public static int Show(int min, int max)
        {
            int pos = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != min)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow & pos != max)
                    pos++;
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.Main();
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return pos;
        }
    }
    internal class Menu2
    {
        public static int Show(int max)
        {
            int pos = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos > 0)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow & pos < max)
                    pos++;
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Program.Main();
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return pos;
        }
    }
}
