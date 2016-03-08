using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Dolgozo
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public string Adoszam { get; private set; }
        public long AlapFizetes { get; private set; }

        public Dolgozo(string nev, string cim, string adoszam, int alapFizetes)
        {
            Nev = nev;
            Cim = cim;
            Adoszam = adoszam;
            AlapFizetes = alapFizetes;
        }

        public virtual long Fizetes()
        {
            return AlapFizetes;
        }

        public override string ToString()
        {
            return "Név: " + Nev + "\tCím: " + Cim;
        }
    }
}
