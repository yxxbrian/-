using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串全排列
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> results = GetResults(input);
            printStringList(results);
            Console.ReadLine();
        }

        static void printStringList(List<string> strList)
        {
            Console.WriteLine("Count:" + strList.Count);
            foreach (string str in strList)
                Console.WriteLine(str);
        }

        static List<char> getAllCharsInString(string str)
        {
            List<char> res = new List<char>();
            foreach (char c in str)
                res.Add(c);
            return res;
        }


        static void getQuanPaiLie(List<string> results, string s, List<char> chars)
        {
            if (chars.Count == 1)
            {
                List<string> nextStringList = new List<string>();
                results.Add(s + chars[0]);
            }
            else
            {
                foreach (char c in chars)
                {
                    List<char> leftChars = new List<char>(chars);
                    leftChars.Remove(c);
                    getQuanPaiLie(results,s + c, leftChars);
                }
            }
        }

        static List<string> GetResults(string str)
        {
            string s = "";
            List<char> chars = getAllCharsInString(str);
            List<string> results = new List<string>();
            getQuanPaiLie(results, s, chars);
            return results;
        }

    }
}
