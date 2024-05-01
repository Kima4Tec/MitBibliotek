using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel; //Skal installeres via NuGet

namespace MitBibliotek
{
    internal class UdTilExcel
    {

        public int ID { get; set; } //properties
        public string Navn { get; set; }
        public string Telefon { get; set; }
        public string Alder { get; set; }

        static void DisplayInExcel(IEnumerable<UdTilExcel> accounts)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "ID Nr. ";
            workSheet.Cells[1, "B"] = "Navn        ";
            workSheet.Cells[1, "C"] = "Telefon ";
            workSheet.Cells[1, "D"] = "Alder  ";

            var row = 1;

            foreach (var acct in accounts)
            {
                row++;
                workSheet.Cells[row, "A"] = acct.ID;
                workSheet.Cells[row, "B"] = acct.Navn;
                workSheet.Cells[row, "C"] = acct.Telefon;
                workSheet.Cells[row, "D"] = acct.Alder;
            }
            workSheet.Columns[1].AutoFit(); //Justerer kolonnebredden, men virker den?.
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();


            workSheet.Range["A1", "D4"].AutoFormat(
                Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);


            excelApp.DisplayAlerts = false; //spørger ikke om du vil overskrive fil
            workSheet.SaveAs(@"C:\dev\MyExcelFile.xlsx"); //gemmer fil på denne sti
            excelApp.Workbooks.Close(); //// lukker Excel Application-objektet
            excelApp.Quit();//quit excel
        }

        public static void GemDataIExcel()
        {
            // Her er data til excel-filen
            var bankAccounts = new List<UdTilExcel> 
            {
                new UdTilExcel {ID = 1, Navn = "Jens Olsen",    Telefon = "22722877", Alder = "39"},
                new UdTilExcel {ID = 2, Navn = "Hans Hansen",   Telefon = "26267123", Alder = "28"},
                new UdTilExcel {ID = 3, Navn = "Peter Sørensen",Telefon = "42462124", Alder = "56"}
            };
            //Se listen i Excel
            DisplayInExcel(bankAccounts);


        }
    }
}
