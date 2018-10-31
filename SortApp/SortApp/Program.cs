using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    class Program
    {
        static void ShowArr(int[] mas, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int N = 10, M = 15;
            int[] a = new int[N];// { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[M];
            Random r = new Random();

            for (int i1 = 0; i1 < N; i1++)
            {
                a[i1] = r.Next(-100, 100);
            }
            for (int i1 = 0; i1 < M; i1++)
            {
                b[i1] = r.Next(-100, 100);
            }

            Array.Sort(a);
            Array.Sort(b);
            ShowArr(a, N);
            ShowArr(b, M);

            //Array.Sort(a);
            //******************* сортировка пузырьком **********
            //for (int k = N-1; k > 0; k--)
            //{
            //    for (int i = 0; i < k; i++)
            //        if(a[i]>a[i+1])
            //        {
            //            int t = a[i];
            //            a[i] = a[i + 1];
            //            a[i + 1] = t;
            //        }
            //    ShowArr(a, N);
            //}

            //******************* сортировка пузырьком с флажком**********
            //bool fl = true;
            //int kol = 0;
            //while(fl)
            //{
            //    fl = false;
            //    for (int i = 0; i < N-kol-1; i++)
            //        if (a[i] > a[i + 1])
            //        {
            //            int t = a[i];
            //            a[i] = a[i + 1];
            //            a[i + 1] = t;
            //            fl = true;
            //        }
            //    kol++;
            //    ShowArr(a, N);
            //}
            //Console.WriteLine(kol);

            //******************* сортировка обменом (max) **********
            //for (int k = N - 1; k > 0; k--)
            //{
            //    int imax = 0;
            //    for (int i = 1; i <= k; i++)
            //        if (a[i] > a[imax])
            //            imax = i;
            //    int t = a[k];
            //    a[k] = a[imax];
            //    a[imax] = t;

            //    ShowArr(a, N);
            //}

            //******************* сортировка вставкой **********
            //for (int k = 1; k < N; k++)
            //{

            //    int  i = k;
            //    while(i > 0 && a[i - 1] > a[i])
            //        {
            //            int t = a[i];
            //            a[i] = a[i - 1];
            //            a[i - 1] = t;
            //            i--;
            //        }
            //    ShowArr(a, N);
            //}


            //******************* объединение упорядоченных массивов **********

            int i = 0, j = 0, k = 0;
            int[] c = new int[N + M];
            
            while(i<N && j<M)
            {
                if (a[i] < b[j])
                    c[k++] = a[i++];
                else
                    c[k++] = b[j++];
            }
            if(i == N)
            {
                for (i = j; i < M; i++)
                    c[k++] = b[i];
            }
            else
            {
                for (j = i; j < N; j++)
                    c[k++] = a[j];
            }

            ShowArr(c, N + M);

            // ******************** пересечение упорядоченных массивов ************
            int[] d = new int[Math.Min(N, M)];
            int dn = 0;
            i = 0;j = 0;

            while (i<N && j<M)
            {
                if (a[i] == b[j])
                {
                    d[dn++] = a[i++];
                    j++;
                }
                else if (a[i] < b[j])
                    i++;
                else
                    j++;
            }
            if (dn == 0)
                Console.WriteLine("Совпадений нет");
            else
                ShowArr(d, dn);











            //ShowArr(a, N);







        }
    }
}
