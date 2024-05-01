using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Linq;

namespace NytExcelProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et forbogstav, som du vil søge på: ");
            string søgeBogstav = Console.ReadLine().ToUpper();
            // Opret et Excel-objekt og åbn arbejdsbogen
            Application excel = new Application();
            Workbook workbook = excel.Workbooks.Open(@"C:\dev\MyExcelFile.xlsx");

            // Vælg det ønskede ark og hent dataene som en 2D-Array
            Worksheet worksheet = workbook.Worksheets["Ark1"];
            Range usedRange = worksheet.UsedRange;
            object[,] values = (object[,])usedRange.Value[XlRangeValueDataType.xlRangeValueDefault];

            // Filtrer dataene baseret på en betingelse
            var filteredValues = Enumerable.Range(1, usedRange.Rows.Count).Where(i => values[i, 1] != null && values[i, 2].ToString().StartsWith(søgeBogstav)).Select(i => values[i, 2]).ToArray();

            Console.WriteLine();
            Console.WriteLine("Resultat af søgning:");

            // Loop igennem de filtrerede data og gør noget med dem
            foreach (var value in filteredValues)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("                    ");
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine(value);
            }
            Console.ResetColor();
            Console.WriteLine( );
            // Luk arbejdsbogen og afslut Excel-objektet
            workbook.Close();
            excel.Quit();
        }
    }
}
