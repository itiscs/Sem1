using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Fraction
    {
        private int chisl;
        private int znam;

        public Fraction(int c, int z)
        {
            chisl = c;
            znam = z;
        }

        public Fraction(int c)
        {
            chisl = c;
            znam = 1;
        }
        public Fraction()
        {
            chisl = 0;
            znam = 1;
        }

        public int GetChisl()
        {
            return chisl;
        }

        public int GetZnam()
        {
            return znam;
        }

        public void SetChisl(int c)
        {
            chisl=c;
        }

        public void SetZnam(int z)
        {
            if (z == 0)
               Console.WriteLine("на ноль делить нельзя");
            else
                znam=z;
        }

        public override string ToString()
        {
            if (znam == 1)
                return $"{chisl}";
            else
                return $"{chisl}/{znam}";
        }




    }


}
