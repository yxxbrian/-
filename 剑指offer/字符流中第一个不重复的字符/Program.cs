using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 请实现一个函数用来找出字符流中第一个只出现一次的字符。
 * 例如，当从字符流中只读出前两个字符"go"时，第一个只出现一次的字符是"g"。
 * 当从该字符流中读出前六个字符“google"时，第一个只出现一次的字符是"l"。
 */
namespace 字符流中第一个不重复的字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string str = "google";
            foreach (char c in str)
            {
                sol.Insert(c);
                char res = sol.FirstAppearingOnce();
                Console.Write(res);
            }
            Console.ReadLine();
        }
    }


    class Solution
    {
        Dictionary<char, int> status = new Dictionary<char, int>();
        public char FirstAppearingOnce()
        {
            // write code here
            foreach (KeyValuePair<char, int> p in status)
                if (p.Value == 1)
                    return p.Key;
            return '#';
        }

        public void Insert(char c)
        {
            // write code here
            if (!status.ContainsKey(c))
                status.Add(c, 0);
            status[c]++;
        }
    }


}
