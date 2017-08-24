using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 整数二进制包含1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int num = sol.NumberOf1(-1);
        }

        class Solution
        {
            public int NumberOf1(int n)
            {
                int count = 0;
                while (n != 0)
                {
                    n &= (n - 1);
                    count++;
                }
                return count;
            }
        }

        /*
         class Solution
        {
            public int NumberOf1(int n)
            {
                int count = 0;
                string base2String = Convert.ToString(n, 2);
                foreach (char c in base2String)
                    if (c == '1')
                        count++;
                return count;
            }
        }
         */
         



        //自己的方法，运行时间： 20 ms 占用内存：2660K
        /*
        class Solution
        {
            public int NumberOf1(int n)
            {
                if (n == Int32.MinValue)
                    return 0;
                int[] status = new int[32];
                // write code here
                int abs = Math.Abs(n);
                for (int i = 31; i >= 0; i--)
                {
                    int curDevide = (int)Math.Pow(2, i);
                    status[i] = abs / curDevide;
                    abs %= curDevide;
                }
                int sum = 0;
                if (n != Math.Abs(n))
                {
                    status = calcBumaForFushu(status);   
                }
                foreach (int i in status)
                    if (i == 1)
                        sum++;
                return sum;
            }

            private int[] calcBumaForFushu(int[] source)
            {
                int[] dst = new int[32];
                for (int i = 0; i < 32; i++)
                {
                    dst[i] = (source[i]+1)%2;
                }
                int jinwei = 1;
                for (int i = 0; i < 32; i++)
                {
                    int tmpRes = dst[i] + jinwei;
                    jinwei = tmpRes / 2;
                    dst[i] = tmpRes % 2;
                }
                return dst;
            }

        }
        */

    }
}
