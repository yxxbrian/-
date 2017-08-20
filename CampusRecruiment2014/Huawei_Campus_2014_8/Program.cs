using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input0 = Console.ReadLine();
            string input1 = Console.ReadLine();
            List<string> chars_0 = new List<string>();
            List<string> chars_1 = new List<string>();
            foreach(char c in input0)
            {
                chars_0.Add(c.ToString());
            }
            foreach (char c in input1)
            {
                chars_1.Add(c.ToString());
            }

            List<int> ints_0 = new List<int>();//low->high
            List<int> ints_1 = new List<int>();//low->high
            for (int i = chars_0.Count - 1; i >= 0; i--)
            {
                ints_0.Add(int.Parse(chars_0[i]));
            }
            for (int i = chars_1.Count - 1; i >= 0; i--)
            {
                ints_1.Add(int.Parse(chars_1[i]));
            }

            List<int> results = new List<int>();//low->high
            bool jiewei = false;
            for (int i = 0; i < ints_0.Count; i++)
            {
                int beijianshuwei = ints_0[i];
                int jianshuwei = 0;
                if (ints_1.Count > i)
                    jianshuwei = ints_1[i];
                int jieshuwei = jiewei ? 1 : 0;
                int result = beijianshuwei - jianshuwei - jieshuwei;
                if (result < 0)
                {
                    result += 10;
                    jiewei = true;
                }
                else
                    jiewei = false;
                results.Add(result);
            }
            bool startZero = true;
            for (int i = results.Count - 1; i >= 0; i--)
            {
                if (results[i] == 0 && startZero)
                { }
                else
                {
                    startZero = false;
                    Console.Write(results[i]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
