using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine("************************************");
        }

        static void MergeSort(int[] arr,int left, int right)
        {
            if (left >= right) return; //остался один элемент 
            if(right - left == 1)      //осталось два элемента
            {
                if (arr[left] > arr[right])
                {
                    int t = arr[left];
                    arr[left] = arr[right];
                    arr[right] = t;
                }
                return;
            }
            int middle = (left + right) / 2; //середина
            MergeSort(arr, left, middle);    //рекурсия первой части
            MergeSort(arr, middle+1, right); //рекурсия второй части
            int[] temp = new int[right - left + 1];  //доп.массив для слияния
            int i1 = left, i2 = middle+1, k=0;
            while (i1 <= middle && i2 <= right)  //пока оба подмассива есть
            {
                if (arr[i1] < arr[i2])
                    temp[k++] = arr[i1++];
                else
                    temp[k++] = arr[i2++];
            }
            if (i1 > middle)  //закончился первый, копируем второй
                while (i2 <= right)
                    temp[k++] = arr[i2++];
            else if (i2 >right) //закончился второй, копируем первый
                while (i1 <= middle)
                    temp[k++] = arr[i1++];

            //ShowArray(temp);
            for (k = 0; k < temp.Length; k++)
                arr[left + k] = temp[k];   //копируем в сотрируемый массив
        }


        static void Main(string[] args)
        {
            int n = 100;
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(100);
            ShowArray(arr);
            MergeSort(arr, 0, arr.Length - 1);
            ShowArray(arr);

        }
    }
}
