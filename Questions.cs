using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class Questions
    {
        public static void Question1()
        {
            int cursorLeft = 4;
            int cursorTop = 1;
            Console.SetCursorPosition(cursorLeft, cursorTop);

            Console.WriteLine("Hvad er Cinderace? (sæt et kryds)");
            Console.SetCursorPosition(cursorLeft, cursorTop + 2);
            Console.WriteLine("[ ] Det er en Pokemon.");
            Console.SetCursorPosition(cursorLeft, cursorTop + 3);
            Console.WriteLine("[ ] Det er en film.");
            Console.SetCursorPosition(cursorLeft, cursorTop + 4);
            Console.WriteLine("[ ] Det er en bil i Mcqueen.");
            Console.SetCursorPosition(cursorLeft, cursorTop + 5);
            Console.WriteLine("[ ] Det er et racerløb i Canada.");
            Program.Right = 3;
            Program.Max = 6;
            MoveCursorPil.FlytOpogNed(5, 3);
            Console.ReadLine();
            Console.Clear();
            Question2();
        }
        public static void Question2()
        {
            int cursorLeft = 4;
            int cursorTop = 1;
            Console.SetCursorPosition(cursorLeft, cursorTop);

            Console.WriteLine("Hvem er den stærkeste Pokemon? (sæt et kryds)");
            Console.SetCursorPosition(cursorLeft, cursorTop + 2);
            Console.WriteLine("[ ] Er det Cinderace?");
            Console.SetCursorPosition(cursorLeft, cursorTop + 3);
            Console.WriteLine("[ ] Er det Mewtwo?");
            Console.SetCursorPosition(cursorLeft, cursorTop + 4);
            Console.WriteLine("[ ] Er det Pikachu?");
            Program.Right = 4;
            Program.Max = 5;
            MoveCursorPil.FlytOpogNed(5, 3);
            Console.WriteLine( );
            Console.WriteLine("Antal rigtige: " + Program.AntalRigtige);
            Console.WriteLine("Antal forkerte: " + Program.AntalForkerte);
            Console.ReadLine();
        }
    }
}
