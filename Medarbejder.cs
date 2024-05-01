using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    public class Medarbejder
    {
        public string Navn { get; set; }
        public string Stilling { get; set; }
        public string Hovedafdeling { get; set; }
        public string Specialafdeling { get; set; }

        public static void MedarbejderListe()
        {
            List<Medarbejder> CMIS = new List<Medarbejder>();
            {
                CMIS.Add(new Medarbejder() { Navn = "Christian Mørk", Stilling = "Direktør", Hovedafdeling = "Ledelse", Specialafdeling = "Regnskab" });
                CMIS.Add(new Medarbejder() { Navn = "Fatima Usul", Stilling = "Regnskabschef", Hovedafdeling = "Ledelse", Specialafdeling = "Regnskab" });
                CMIS.Add(new Medarbejder() { Navn = "Jørgen Espersen", Stilling = "Salgschef", Hovedafdeling = "Ledelse", Specialafdeling = "Salg" });
                CMIS.Add(new Medarbejder() { Navn = "Bavranjan Gupta", Stilling = "IT-chef   ", Hovedafdeling = "Ledelse", Specialafdeling = "IT" });
            };
            LINQbib.LINQ(CMIS);
        }
    }
}
