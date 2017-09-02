using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 输入一个字符串,按字典序打印出该字符串中字符的所有排列。
 * 例如输入字符串abc,则打印出由字符a,b,c所能排列出来的
 * 所有字符串abc,acb,bac,bca,cab和cba。
 */
namespace 字符串的排列
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> r = new Solution().Permutation("abc");
        }

        



        //44 ms	3556K 算法有待优化
        class Solution
        {
            public List<string> Permutation(string str)
            {
                // write code here
                List<string> result = new List<string>();
                List<char[]> tmpResult = getNext(str.ToArray<char>());
                foreach (char[] t in tmpResult)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in t)
                        sb.Append(c);
                    string s = sb.ToString();
                    if (!result.Contains(s))
                        result.Add(sb.ToString());
                }
                return result;
            }


            public List<char[]> getNext(char[] strChars)
            {
                List<char[]> retRes = new List<char[]>();
                if (strChars.Length == 1)
                {
                    retRes.Add(new char[]{ strChars[0]});
                    return retRes;
                }
                for (int i = 0; i < strChars.Length; i++)
                {
                    char[] nextParam = new char[strChars.Length-1];
                    int index = 0;
                    for (int j = 0; j < strChars.Length; j++)
                    {
                        if (j != i)
                            nextParam[index++] = strChars[j];
                    }
                    List<char[]> nextResult = getNext(nextParam);
                    foreach (char[] t in nextResult)
                    {
                        char[] n = new char[t.Length + 1];
                        n[0] = strChars[i];
                        int p = 1;
                        foreach (char d in t)
                            n[p++] = d;
                        retRes.Add(n);
                    }
                }
                return retRes;
            }
        }

    }
}
