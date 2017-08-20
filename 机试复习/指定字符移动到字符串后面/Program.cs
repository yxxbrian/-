using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 指定字符移动到字符串后面
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            char c = Console.ReadLine().ToCharArray()[0];
            List<char> charList = getChars(inputStr);
            Process(charList, c);
            printCharList(charList);
            Console.ReadLine();
        }

        static void printCharList(List<char> chars) 
        {
            foreach (char c in chars)
                Console.Write(c);
            Console.WriteLine();
        }
        static List<char> getChars(string str)
        {
            List<char> res = new List<char>();
            foreach (char c in str)
                res.Add(c);
            return res;
        }

        static void Process(List<char> charList, char ch)
        {
            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 0; i < charList.Count - 1; i++)
                {
                    if (charList[i] == ch && charList[i+1] != ch)
                    {
                        exchangeChar(charList, i, i + 1);
                        changed = true;
                    }
                }
            }
        }

        static void exchangeChar(List<char> chars, int i, int j)
        {
            char tmp = chars[i];
            chars[i] = chars[j];
            chars[j] = tmp;
        }
    }
}
