using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class ChooseItem
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
                //LINQ()
                if (key.KeyChar == 'x')
                {
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write("x");
                    //valg nr 1
                    if (cursorTop == 3)
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.Clear();
                        FlytCursorRundt.FlytCursoren();
                        break;
                    }
                    //valg nr 2
                    else if (cursorTop == 4)
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.Clear();
                        Medarbejder.MedarbejderListe();
                        break;
                    }
                    //valg nr 3
                    else if (cursorTop == 5)
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.Clear();
                        Matematik.LogiskOperator();
                        break;
                    }
                    //valg nr 4
                    else if (cursorTop == 6)
                    {
                        Console.SetCursorPosition(4, 7);
                        Console.Clear();
                        var navnMedStort = KeyPress.StortB("kim");
                        Console.WriteLine($"Fra kim til {navnMedStort}");
                        break;
                    }
                    else { break;}
                }

                Console.SetCursorPosition(cursorLeft, cursorTop);
            }
        }
    }
}
