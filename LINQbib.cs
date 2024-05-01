using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class LINQbib
    {
        public static void LINQ(List<Medarbejder> CMIS)
        {
            string valg = "";

            Console.WriteLine("LINQ Menu\n");

            Console.WriteLine("Tast (1) for GroupBy\n" +
                "Tast (2) for OrderBy\n" +
                "Tast (3) for Where\n" +
                "Tast (4) for Select\n" +
                "Tast (5) for Count\n" +
                "Tast (6) for ReadAll\n" +
                "Tast (q) for Quit\n");

                valg = Console.ReadLine();
                switch (valg)
            {
                case "1":
                    {
                            Console.Clear();
                            LINQGroupBy(CMIS);
                            break;

                    }
                case "2":
                    {
                            Console.Clear();
                            LINQOrderBy(CMIS);
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        LINQWhere(CMIS);
                        break;
                    }
                case "4":
                    {
                            Console.Clear();
                            LINQSelect(CMIS);
                        break;
                    }
                case "5":
                    {
                            Console.Clear();
                            LINQCount(CMIS);
                        break;
                    }
                case "6":
                    {
                        Console.Clear();
                        ReadAll(CMIS);
                        break;
                    }
                case "q":
                    {
                            Console.Clear();
                            Console.WriteLine("Du forlader LINQ menuen.");
                        break;
                    }
                default:
                    {
                            break;
                    }
                }
            
        }


        public static void LINQGroupBy(List<Medarbejder> CMIS)
        {
            //GroupBy: Bruges til at gruppere elementer i en samling baseret på en bestemt egenskab
            var resultat1 = CMIS.GroupBy(p => p.Hovedafdeling);
            foreach (var group in resultat1)
            {
                Console.WriteLine("Hovedafdeling: " + group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine("- " + person.Navn);
                }
            }
            var resultat2 = CMIS.GroupBy(p => p.Specialafdeling);
            foreach (var group in resultat2)
            {
                Console.WriteLine("\nSpecielfdeling: " + group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine("- " + person.Navn);
                }
            }
            Console.ReadLine();
            MitBibIndhold.Indholdsfortegnelse();
        }//slut Group

         //OrderBy og OrderByDescending: Bruges til at sortere elementer i en samling i stigende eller faldende rækkefølge baseret på en bestemt egenskab.
        public static void LINQOrderBy(List<Medarbejder> CMIS)
        {
            var sortListe = CMIS.OrderBy(p => p.Navn);
            foreach (var item in sortListe)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadLine();
            MitBibIndhold.Indholdsfortegnelse();
        }
        //Where: Bruges til at filtrere elementer i en samling, der opfylder en bestemt betingelse.
        public static void LINQWhere(List<Medarbejder> CMIS)
        {
            var navnStarterMed = CMIS.Where(x => x.Navn.StartsWith("B"));
            foreach (var item in navnStarterMed)
            {
                Console.WriteLine(item.Navn);
              
            }
            Console.ReadLine();
            MitBibIndhold.Indholdsfortegnelse();
        }

        //Select: Bruges til at transformere elementer i en samling ved at anvende en funktion på hvert element.
        public static void LINQSelect(List<Medarbejder> CMIS)
        {
            var upperCaseNavne = CMIS.Select(x => x.Navn.ToUpper());
            foreach (var upperNavn in upperCaseNavne)
            {
                Console.WriteLine("Navn: " + upperNavn + "\n");
            }
            Console.ReadLine();
            MitBibIndhold.Indholdsfortegnelse();
        }

        //Count: Bruges til at tælle antallet af elementer i en samling, der opfylder en bestemt betingelse.
        public static void LINQCount(List<Medarbejder> CMIS)
        {
            int lettersCount = CMIS.Count(x => x.Navn.Length > 14); //hvor mange navne har mere end 14 tegn

                Console.WriteLine(lettersCount);
            Console.ReadLine();
            MitBibIndhold.Indholdsfortegnelse();
        }
        public static void ReadAll(List<Medarbejder> CMIS)
        {
            foreach (var item in CMIS)
            {
                Console.WriteLine(item.Navn + "\t\t" + item.Stilling+ "\t" + item.Hovedafdeling + "\t" + item.Specialafdeling);
            }
        }

    }
}
