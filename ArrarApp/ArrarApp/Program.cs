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
            int n = 100;
            
            //int[] a = {1,2,3,4,5,6,7};
            int[] a = new int[n];
            Random r = new Random();

            bool fl = true;
            for (int i = 0; i < n; i++)
            {
                //a[i] = n - i;
                //    a[i] = int.Parse(Console.ReadLine());
                a[i] = r.Next(-100,100);
                if (a[i] == 0)
                    fl = false;
            }

            int sum = 0;
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {a[i]}\n");
                sum += a[i];
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine($"Sum = {sum} Max = {max}");

        }
    }
}
