using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> chars = new List<char>();
            foreach (char c in input)
            {
                chars.Add(c);
            }
            bool valid = true;
            for (int i = 0; i < chars.Count / 2; i++)
            {
                if (chars[i] != chars[chars.Count - 1 - i])
                    valid = false;
            }
            Console.Write(valid == true ? 1 : 0);
            Console.ReadKey();
        }
    }
}
