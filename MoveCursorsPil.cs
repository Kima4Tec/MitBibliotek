using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class MoveCursorPil
    {
        public static void FlytOpogNed(int cursorLeft, int cursorTop)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (cursorTop < Program.Max)
                    {
                        cursorTop++;
                    }

                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (cursorTop > 3)
                    {
                        cursorTop--;
                    }
                }

                if (key.KeyChar == 'x')
                {
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write("x");
                    if (cursorTop == Program.Right)
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.WriteLine("Det er rigtigt!");
                        Program.AntalRigtige++;
                        return;
                    }
                    else
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.WriteLine("Det er forkert!");
                        Program.AntalForkerte++;
                        return;
                    }
                }

                Console.SetCursorPosition(cursorLeft, cursorTop);
            }
        }
    }
}
