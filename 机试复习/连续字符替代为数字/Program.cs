using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 连续字符替代为数字
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            List<char> chars = inputStr.ToCharArray().ToList();
            PrintRes(Process(chars));
            Console.ReadLine();

        }

        static void PrintRes(List<KeyValuePair<char,int>> res)
        {
            foreach (KeyValuePair<char, int> v in res)
            {
                string t = v.Value.ToString()+v.Key.ToString();
                Console.Write(t);
            }
            Console.WriteLine();
        }

        static List<KeyValuePair<char,int>> Process(List<char> chars)
        {
            List<KeyValuePair<char,int>> res = new List<KeyValuePair<char,int>>();
            foreach (char curChar in chars)
            {
                if (res.Count == 0 || res[res.Count - 1].Key != curChar)
                {
                    KeyValuePair<char, int> newpair = new KeyValuePair<char, int>(curChar, 1);
                    res.Add(newpair);
                }
                else
                {
                    res[res.Count - 1] = new KeyValuePair<char, int>(res[res.Count - 1].Key, res[res.Count - 1].Value + 1);
                }
            }
            return res;
        }

    }
}
