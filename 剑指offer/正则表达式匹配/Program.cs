using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 请实现一个函数用来匹配包括'.'和'*'的正则表达式。
 * 模式中的字符'.'表示任意一个字符，而'*'表示它前面的字符可以出现任意次（包含0次）。 
 * 在本题中，匹配是指字符串的所有字符匹配整个模式。
 * 例如，字符串"aaa"与模式"a.a"和"ab*ac*a"匹配，但是与"aa.a"和"ab*a"均不匹配
 */
namespace 正则表达式匹配
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1 sol = new Solution1();
            string str = "";
            string pattern = ".";
            bool result = sol.match(str.ToCharArray(),pattern.ToCharArray());
        }
    }


    class Solution1
    {
        public bool match(char[] str, char[] pattern) 
        {
            return match(str, 0, pattern, 0);
        }


        private bool match(char[] str, int strCurIndex, char[] pattern, int patCurIndex) 
        {
            if (strCurIndex == str.Length && patCurIndex == pattern.Length)
            {
                return true;
            }
            else if (strCurIndex < str.Length && patCurIndex == pattern.Length)
            {
                return false;
            }

            if(patCurIndex+1<=pattern.Length-1 && pattern[patCurIndex+1] == '*')
            {
                if (strCurIndex < str.Length && (pattern[patCurIndex] == str[strCurIndex] || pattern[patCurIndex] == '.'))
                    return match(str, strCurIndex, pattern, patCurIndex + 2) || match(str, strCurIndex + 1, pattern, patCurIndex + 2) || match(str, strCurIndex + 1, pattern, patCurIndex);
                else
                    return match(str, strCurIndex, pattern, patCurIndex + 2);
            }
            else
            {
                if (strCurIndex <str.Length && (pattern[patCurIndex] == str[strCurIndex] || pattern[patCurIndex] == '.'))
                {
                    return match(str, strCurIndex+1, pattern, patCurIndex+1);
                }
                else
                    return false;
            }
        }
    
    }




    class Solution
    {
        public bool match(char[] str, char[] pattern)
        {
            // write code here
            //Fix Pattern
            List<char> newPattern = pattern.ToList<char>();
            for(int i=1;i<newPattern.Count-1;i++)
            {
                if (newPattern[i] == '*' && newPattern[i - 1] == newPattern[i + 1])
                    newPattern.RemoveAt(i + 1);
            }
            pattern = newPattern.ToArray<char>();

            int index0 = 0;
            int index1 = 0;
            while (index0 < str.Length && index1 < pattern.Length)
            {
                if (str[index0] == pattern[index1])
                {
                    index0++;
                    index1++;
                    continue;
                }
                else 
                {
                    if (pattern[index1] == '.')
                    {
                        index0++;
                        index1++;
                        continue;
                    }
                    else if (pattern[index1] == '*')
                    {
                        while (index0<str.Length && (str[index0] == pattern[index1 - 1] || pattern[index1-1] == '.')) 
                        {
                            index0++;
                        }
                        index1++;
                        continue;
                    }
                    else if (index1 + 1 <pattern.Length && pattern[index1 + 1] == '*')
                    {
                        index1 += 2;
                        continue;
                    }
                    return false;
                }
            }
            if (index0 == str.Length)
            {
                if (index1 == pattern.Length)
                    return true;
                else if (index0 == str.Length)
                {
                    while (index1 < pattern.Length)
                    {
                        if (pattern[index1] == '*')
                        {
                            index1++;
                            continue;
                        }
                        if (index1 + 1 < pattern.Length && pattern[index1 + 1] == '*')
                        {
                            index1 += 2;
                            continue;
                        }
                        else
                            return false;
                    }
                    if (index1 == pattern.Length)
                        return true;
                }
            }
            return false;
        }
    }

}
