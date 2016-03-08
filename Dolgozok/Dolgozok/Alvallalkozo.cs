using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Alvallalkozo : Dolgozo, IComparable
    {
        public int SzerzodesVeg { get; private set; }
        public string Feladat { get; private set; }
        public long SikerDij { get; private set; }

        public Alvallalkozo(string nev, string cim, string adoszam, int alapFizetes, int szerzodesVeg, string feladat, int sikerDij) : base(nev, cim, adoszam, alapFizetes)
        {
            SzerzodesVeg = szerzodesVeg;
            Feladat = feladat;
            SikerDij = sikerDij;
        }

        public override long Fizetes()
        {
            return base.Fizetes() + SikerDij;
        }

        public override string ToString()
        {
            return "Szerződés vége: " + SzerzodesVeg + "/tNév: " + Nev;
        }

        public int CompareTo(object obj)
        {
            Alvallalkozo other = obj as Alvallalkozo;

            if(other != null)
            {
                if (SzerzodesVeg > other.SzerzodesVeg) return -1;
                if (SzerzodesVeg < other.SzerzodesVeg) return 1;
                return Nev.CompareTo(other.Nev);
            }
            return -1;
        }
    }
}
