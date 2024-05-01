using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class MitBibIndhold
    {
        public static void Indholdsfortegnelse()
        {
            Console.Clear();
            int cursorLeft = 4;
            int cursorTop = 1;
            Console.SetCursorPosition(cursorLeft, cursorTop);

            Console.WriteLine("Vælg et emne. (sæt et kryds)");
            Console.SetCursorPosition(cursorLeft, cursorTop + 2);
            Console.WriteLine("[ ] Flyt cursor rundt");
            Console.SetCursorPosition(cursorLeft, cursorTop + 3);
            Console.WriteLine("[ ] LINQ");
            Console.SetCursorPosition(cursorLeft, cursorTop + 4);
            Console.WriteLine("[ ] Logiske operatorer");
            Console.SetCursorPosition(cursorLeft, cursorTop + 5);
            Console.WriteLine("[ ] Egennavne med stort begyndelsebogstav");
            Program.Max = 6;
            ChooseItem.FlytOpogNed(5, 3);
        }
    }
}
