using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopChar = " ,.!";
            String s = "Привет, Мир, Россия, Казань!";
            s = s.ToUpper();
            Console.WriteLine(s);

            StringBuilder sb = new StringBuilder();

            List<char> li = new List<char>();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char ch in s)
            {
                if (stopChar.Contains(ch))
                    continue;

                if (! li.Contains(ch))
                    li.Add(ch);

                if (!dict.Keys.Contains(ch))
                    dict[ch] = 1;
                else
                    dict[ch] = dict[ch] + 1;
 
            }
            //for (int i = 0; i < li.Count; i++)
            //    Console.WriteLine(li[i]);
            foreach (char ch in li)
                Console.WriteLine(ch);
            Console.WriteLine("***********************************************");
            foreach (char ch in dict.Keys)
                Console.WriteLine($"{ch} --- {dict[ch]}");


            //Console.WriteLine(s);






















        }
    }
}
