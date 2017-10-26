using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, k, l, m, eps;
            int i = 0;

            //n = int.Parse(Console.ReadLine());
            S = k = m = l = 1;
            eps = double.Parse(Console.ReadLine());


            //for(int i=1; i<=n; i++)
            //{
            //    k = -k;
            //    l = 2 * i + 1;
            //    m *= 3;
            //    S += k / (l * m);
            //}
            while (Math.Abs(k/(l*m)) > eps)
            {
                i++;
                k = -k;
                l = 2 * i + 1;
                m *= 3;
                S += k / (l * m);
            }

            Console.WriteLine($"Sum={S}  n={i}");
















        }
    }
}
