using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Fraction
    {
        private static int kol = 0;
        
        private int chisl;
        private int znam;

        public int Chisl
        {
            get
            {
                return chisl;
            }
            set
            {
                chisl = value;
                sokr();
            }
        }
        
        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                if (value == 0)
                    Console.WriteLine("Деление на ноль");
                else
                    znam = value;
                sokr();
            }
        }
        private int nod(int a,int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        private void sokr()
        {
            var n = nod(chisl, znam);
            chisl /= n;
            znam /= n;
        }

        public Fraction(int c, int z)
        {
            chisl = c;
            znam = z;
            kol++;
            sokr();
        }

        public Fraction(int c):this(c,1)
        {
            //chisl = c;
            //znam = 1;
        }
        public Fraction():this(0,1)
        {
            //chisl = 0;
            //znam = 1;
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

        public static void StaticMethod(int x)
        {
            Console.WriteLine($"Статичный метод {x}");

        }

        public static int CountOfObjects()
        {
            return kol;

        }




    }


}
