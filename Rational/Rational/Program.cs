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
            Rational r;
            r = new Rational(1,0);
            
            r.Show();

            r.SetChisl(3);

            r.Show();

            Rational r1 = new Rational(10,2);
            Rational r2 = new Rational(-1,3);


            //r1.Show();
            //r2.Show();
            Console.WriteLine($"r1={r1}");
            Console.WriteLine($"r2={r2}");

            Rational r3 = new Rational();
            r3.Sum(r1, r2);
            
            Console.WriteLine($"r1+r2={r3}");

            Rational r4 = r3 + r2;
            Console.WriteLine($"r3+r2={r4}");


            //Console.WriteLine(r);
        }
    }
}
