using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Kiszervezett : Dolgozo, IComparable
    {
        public string Munkakor { get; private set; }
        public string Munkaltato { get; private set; }
        public int Muszakpotlek { get; private set; }

        public Kiszervezett(string nev, string cim, string adoszam, int alapFizetes, string munkakor, string munkaltato, int muszakPotlek) : base(nev, cim, adoszam, alapFizetes)
        {
            Munkakor = munkakor;
            Munkaltato = munkaltato;
            Muszakpotlek = muszakPotlek;
        }

        public override long Fizetes()
        {
            return base.Fizetes() + Muszakpotlek;
        }

        public override string ToString()
        {
            return "Munkáltató: " + Munkaltato + "\tNév: " + Nev;
        }

        public int CompareTo(object obj)
        {
            Kiszervezett other = obj as Kiszervezett;

            if (other != null)
            {
                int compare = Munkaltato.CompareTo(other.Munkaltato);

                if (compare == 0) return Nev.CompareTo(other.Nev);
                return Munkaltato.CompareTo(other.Munkaltato);
            }
            return -1;
        }
    }
}
