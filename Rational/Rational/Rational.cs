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

        public int Chisl
        {
            get
            {
                return chisl;
            }
            set
            {
                chisl = value;
            }
        }

        public int Znam {
            get
            {
                return znam;
            }
            set
            {
                if (value > 0)
                    znam = value;
                else
                    throw new Exception("Знаменатель должен быть больше нуля");
            }
           }

 






        public Rational(int c, int z)
        {
            if (z != 0)
            {
                this.Chisl = c;
                this.Znam = z;
            }
            else 
                throw new DivideByZeroException("Делим на ноль!!!!!!!!!"); 
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
            this.Chisl = c;
        }

        public int GetChisl()
        {
            return Chisl;
        }

        public void Show()
        {
            Console.WriteLine($"{Chisl}/{Znam}");
        }

        public override string ToString()
        {
            if (Znam == 1)
                return $"{Chisl}";

            return $"{Chisl}/{Znam}";
            
        }

        public static Rational operator+(Rational a, Rational b)
        {
            int c = a.Chisl * b.Znam + a.Znam * b.Chisl;
            int z = a.Znam * b.Znam;
            Rational r = new Rational(c, z);
            return r;
        }

        public void Sum(Rational a, Rational b)
        {
            Chisl = a.Chisl * b.Znam + a.Znam * b.Chisl;
            Znam = a.Znam * b.Znam;
        }














    }
}
