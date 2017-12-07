using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{

    class Rational
    {
        private int chisl;
        private int znam;

        public Rational(int c, int z)
        {
            if (z != 0)
            {
                this.chisl = c;
                this.znam = z;
            }
        }

        public Rational(int c):this(c,1)
        {
            //this.chisl = c;
            //this.znam = 1;
        }

        public Rational():this(0)
        {
            //this.chisl = 0;
            //this.znam = 1;
        }


        public void SetChisl(int c)
        {
            this.chisl = c;
        }

        public int GetChisl()
        {
            return chisl;
        }

        public void Show()
        {
            Console.WriteLine($"{chisl}/{znam}");
        }

        public override string ToString()
        {
            if (znam == 1)
                return $"{chisl}";

            return $"{chisl}/{znam}";
            
        }

        public static Rational operator+(Rational a, Rational b)
        {
            int c = a.chisl * b.znam + a.znam * b.chisl;
            int z = a.znam * b.znam;
            Rational r = new Rational(c, z);
            return r;
        }

        public void Sum(Rational a, Rational b)
        {
            chisl = a.chisl * b.znam + a.znam * b.chisl;
            znam = a.znam * b.znam;
        }














    }
}
