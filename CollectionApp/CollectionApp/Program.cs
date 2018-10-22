using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10, m = 10;
            //int[,] a = new int[m, n];

            ////int[][] mas = new int[5][];
            ////for(int i=0;i<5;i++)
            ////{
            ////    mas[i] = new int[i + 5];
            ////}

            //int[] b = new int[m * n];


            //for(int i=0; i<m; i++)
            //    for(int j=0; j<n; j++)
            //        if(i==j)
            //            b[i*n+j] = j+1;

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write($"{b[i*n+j]} ");
            //    Console.WriteLine();
            //}


            List<int> lst = new List<int>();

            Random r = new Random();

            for(int i=0;i<4097;i++)
                lst.Add(i*11);

            //lst.Sort();
            //lst.Remove(11);

            //for (int i = 0; i < lst.Count; i++)
            //    Console.WriteLine(lst[i]);

            lst.Reverse();
            Console.WriteLine($"содержит 11? = {lst.Contains(11)}");
            //lst.Distinct();

            foreach (int item in lst)
            {
                //Console.WriteLine(item);
            }

            


        }
    }
}
