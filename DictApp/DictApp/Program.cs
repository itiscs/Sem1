using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lst = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            string str = Console.ReadLine();
            
            var arr = str.Split(' ');
            
            foreach (var item in arr)
            {
                if (!dict.Keys.Contains(item))
                    dict.Add(item, 1);
                else
                    dict[item] = dict[item] + 1;

                //if (!lst.Contains(item))
                //    lst.Add(item);
            }

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}
            
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -- {item.Value}");
            }







        }
    }
}
