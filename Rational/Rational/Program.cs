using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
   
    
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(5);
            Fraction f = new Fraction(9,12);

            Console.WriteLine($"f={f}");
            Console.WriteLine($"f1={f1}");
            Console.WriteLine($"f2={f2}");

            //f.SetChisl(6);
            f.Chisl = 6;
            f.Znam = 18;
            //int x = f.Chisl;

            Console.WriteLine($"f={f}");

            f.Znam = 0;
            
            
            Console.WriteLine($"f={f}");

            Console.WriteLine($"kolvo - {Fraction.CountOfObjects()}");
            //Fraction.procent = 7;

            Fraction f5 = new Fraction(30, 45);
            Console.WriteLine($"f5={f5}");

            Console.WriteLine($"kolvo - {Fraction.CountOfObjects()}");


            //Rational r;
            //r = new Rational(1,0);

            //r.Show();

            //r.Chisl = 3;

            //r.Show();

            //Rational r1 = new Rational(10,2);
            //Rational r2 = new Rational(-1,3);


            ////r1.Show();
            ////r2.Show();
            //Console.WriteLine($"r1={r1}");
            //Console.WriteLine($"r2={r2}");

            //Rational r3 = new Rational();
            //r3.Sum(r1, r2);

            //Console.WriteLine($"r1+r2={r3}");

            //Rational r4 = r3 + r2;
            //Console.WriteLine($"r3+r2={r4}");


            ////Console.WriteLine(r);
        }
    }

    
}
