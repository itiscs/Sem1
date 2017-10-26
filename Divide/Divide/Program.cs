using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c=0, fa, fb, fc=0, eps;
            a = Math.PI / 4;
            b = 5 * a;
            fa = Math.Sin(a) + Math.Cos(a);
            fb = Math.Sin(b) + Math.Cos(b);
            eps = double.Parse(Console.ReadLine());
            while( (b-a) > eps)
            {
                c = (b + a) / 2;
                fc = Math.Sin(c) + Math.Cos(c);
                if (fc == 0)
                    break;
                if(fa*fc < 0)
                {
                    b = c;
                    fb = fc;
                }
                else
                {
                    a = c;
                    fa = fc;
                }
            }
            Console.WriteLine($"f({c}) = {fc}");



















        }
    }
}
