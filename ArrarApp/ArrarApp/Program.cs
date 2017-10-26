using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, sum = 0;
            int[] a = {1,2,3,4,5};
            int[,] b = new int[n,n];
           
            Random r = new Random();

            for (int i = 0; i < n; i++)
                a[i] = r.Next(-100, 100);
            //a[i] = int.Parse(Console.ReadLine);

            int max = a[0], imax=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i],3}");
                //sum += a[i];
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
            }
            Console.WriteLine($"sum={sum}");

            //int s = 0;
            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < n; j++)
            //    {
            //        b[i, j] = r.Next(-100,100);
            //        s += b[i, j];
            //    }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write($"{b[i, j],4}");
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"s={s}");




        }
    }
}
