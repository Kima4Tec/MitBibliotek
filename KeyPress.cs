using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitBibliotek
{
    internal class KeyPress
    {
        public static string StortB(string egennavn)
        {
            string lille = egennavn.ToLower();
            string førsteBogstav = lille.Substring(0, 1).ToUpper();
            string resten = lille.Substring(1);
            return førsteBogstav + resten;
        }
    }
}
