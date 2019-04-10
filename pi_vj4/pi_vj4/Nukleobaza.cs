using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_vj4
{
    class Nukleobaza
    {
        public string Baza { get; set; }
        public string Par { get; set; }

        public Nukleobaza()
        {
        }

        public string OdrediPar(string baza)
        {
            switch (baza)
            {
                case "A":
                    return "T";
                case "C":
                    return "G";
                case "T":
                    return "A";
                case "G":
                    return "C";
                default:
                    return "";
            }
        }

        public override string ToString()
        {
            return $"{this.Baza} - {this.Par}";
        }
    }
}
