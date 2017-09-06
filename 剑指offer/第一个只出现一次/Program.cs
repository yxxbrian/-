using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 在一个字符串(1<=字符串长度<=10000，全部由字母组成)
 * 中找到第一个只出现一次的字符,并返回它的位置
 */
namespace 第一个只出现一次
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                int index = new Solution().FirstNotRepeatingChar(str);
                Console.WriteLine(index);
            }
        }
    }

    class Solution
    {
        public int FirstNotRepeatingChar(string str)
        {
            // write code here
            if (str.Length == 0)
                return -1;
            else if (str.Length == 1)
                return 0;
            else
            {
                int[] countTable = new int[128];
                foreach (char c in str)
                    countTable[c]++;
                for (int i = 0; i < str.Length; i++)
                {
                    if (countTable[str[i]] == 1)
                        return i;
                }
                return -1;
            }
        }
    }

}
