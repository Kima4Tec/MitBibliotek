using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class Program
    {
        public static int AntalRigtige { get; set; }
        public static int AntalForkerte { get; set; }

        public static int Right { get; set; }
        public static int Max { get; set; } //Hvor langt kan cursoren Max gå ned i checkboxe?
        public static int Min { get; set; }
        public static void Skriv(int x, int y, string tekst)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(tekst);
        }
    static void Main(string[] args)
        {

            MitBibIndhold.Indholdsfortegnelse();
            //Medarbejder.MedarbejderListe();
            //Questions.Question1();
            //Console.Clear();
            //Questions.Question2();
            //Skriv(4, 9, $"Antal rigtige svar: {Program.AntalRigtige}");
            //Console.ReadLine();
            //Matematik.LogiskOperator();
            //UdTilExcel.GemDataIExcel();
            //IndFraExcel.HentFraExcel();
            Console.ReadLine();
        }



    }//slut class
}
