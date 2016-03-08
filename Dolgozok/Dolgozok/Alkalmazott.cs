using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Alkalmazott : Dolgozo
    {
        public string BelsoAzonosito { get; private set; }
        public string Beosztas { get; private set; }
        public int Tuloradij { get; private set; }
        public int Tulora { get; private set; }

        public Alkalmazott(string nev, string cim, string adoszam, int alapFizetes, string belsoAzonosito, string beosztas, int tuloradij, int tulora) : base(nev, cim, adoszam, alapFizetes)
        {
            Beosztas = beosztas;
            BelsoAzonosito = belsoAzonosito;
            Tuloradij = tuloradij;
            Tulora = tulora;
        }

        public override long Fizetes()
        {
            return base.Fizetes() + Tulora * Tuloradij;
        }

        public override string ToString()
        {
            return "Beosztás: " + Beosztas + "/tNév: " + Nev;
        }
    }
}
