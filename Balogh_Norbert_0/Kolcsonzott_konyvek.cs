using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balogh_Norbert_0
{
    class Kolcsonzott_konyvek
    {
        string kolcsonzo;
        string szerzo;
        string cim;
        int peldany;
        string ISBN;
        DateTime datum;

        public Kolcsonzott_konyvek(string kolcsonzo, string szerzo, string cim, int peldany, string iSBN, DateTime datum)
        {
            this.Kolcsonzo = kolcsonzo;
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.Peldany = peldany;
            ISBN1 = iSBN;
            this.Datum = datum;
        }

        public string Kolcsonzo { get => kolcsonzo; set => kolcsonzo = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Peldany { get => peldany; set => peldany = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return $"{Kolcsonzo} -> {Szerzo}: {Cim} ({Peldany}db)";
        }
    }
}
