using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y, y1, eps=0.000001;
            if (x > 1)
                y1 = x / 3;
            else
                y1 = x;
            int k = 0;
            do
            {
                k++;
                y = y1;
                y1 = y - (y - x / (y * y)) / 3;

            }
            while (Math.Abs(y1 - y) > eps );

            Console.WriteLine($"{y}   {y*y*y}   {k}-шаг");


        }
    }
}
