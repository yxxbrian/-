using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 写一个函数，求两个整数之和，要求在函数体内不得使用+、-、*、/四则运算符号。
 */
namespace 不用加减乘除做加法
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Solution
    {
        public int Add(int num1, int num2)
        {
            // write code here
            while (num2 != 0)
            {
                int jinweipart = (num1 & num2) << 1;
                int nojinweipart = (num1 ^ num2);
                num1 = nojinweipart;
                num2 = jinweipart;
            }
            return num1;
        }
    }


}
