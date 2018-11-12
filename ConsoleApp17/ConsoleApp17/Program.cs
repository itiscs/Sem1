using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static double f(double x)
        {
            return Math.Cos(x) + Math.Sin(x);
        }

        public static double root(double a, double b, double eps)
        {
            double c = (a + b) / 2;
            double fc = f(c);
            if (fc < eps)
                return c;

            double fa = f(a), fb = f(b);

            if (fa * fc > 0)
                return root(c, b, eps);
            else
                return root(a, c, eps);
        }



        public static void Main()
        {
            double a = Math.PI / 4;
            double b = Math.PI * 5 / 4;
            double eps = 0.00001;


            Console.WriteLine(root(a, b, eps));


        }
    }
}


