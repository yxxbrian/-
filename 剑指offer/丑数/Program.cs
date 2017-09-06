using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

/*
 * 把只包含因子2、3和5的数称作丑数（Ugly Number）。
 * 例如6、8都是丑数，但14不是，因为它包含因子7。 
 * 习惯上我们把1当做是第一个丑数。求按从小到大的顺序的第N个丑数。
 */

namespace 丑数
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //Solution sol = new Solution();
            Solution2 sol = new Solution2();
            int res = sol.GetUglyNumber_Solution(7);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        class Solution2
        {
            public int GetUglyNumber_Solution(int index) 
            {
                if (index == 0)
                    return 0;
                int[] ugly_values = new int[index];
                ugly_values[0] = 1;
                int index_2 = 0, index_3 = 0, index_5 = 0;
                for (int i = 1; i < index; i++)
                {   
                    int tmp_val = Math.Min(ugly_values[index_2] * 2, Math.Min(ugly_values[index_3] * 3, ugly_values[index_5] * 5));
                    ugly_values[i] = tmp_val;
                    if (tmp_val == ugly_values[index_2] * 2)
                        index_2++;
                    if (tmp_val == ugly_values[index_3] * 3)
                        index_3++;
                    if (tmp_val == ugly_values[index_5] * 5)
                        index_5++;
                }
                return ugly_values[index - 1];
            }

        }


        //Other's
        class Solution1
        {
            public int GetUglyNumber_Solution(int index)
            {
                // write code here
                if (index <= 0)
                    return 0;

                int t2 = 0, t3 = 0, t5 = 0;
                var val = new int[index];
                val[0] = 1;
                for (int i = 1; i < index; i++)
                {
                    val[i] = min(val[t2] * 2, val[t3] * 3, val[t5] * 5);
                    if (val[i] == val[t2] * 2)
                        t2++;
                    if (val[i] == val[t3] * 3)
                        t3++;
                    if (val[i] == val[t5] * 5)
                        t5++;
                }
                return val[index - 1];
            }

            private int min(int x, int y, int z)
            {
                int m = x;
                if (y < m)
                    m = y;
                if (z < m)
                    m = z;
                return m;
            }
        }

        //Mine bad Complexity
        class Solution
        {
            List<int> uglyNumList = new List<int>();
            public int GetUglyNumber_Solution(int index)
            {
                // write code here
                int uglyNumIndex = 0;
                int uglyNum = 0;
                int i=1;
                while (uglyNumIndex < index)
                {
                    if (isUglyNumber(i))
                    {
                        uglyNumIndex++;
                        uglyNum = i;
                        uglyNumList.Add(uglyNum);
                    }
                    i++;
                }
                return uglyNum;
            }

            private bool isUglyNumber(int i) 
            {
                if (uglyNumList.Contains(i))
                    return true;
                else 
                {
                    if (i == 1 || i == 2 || i == 3 || i == 5)
                        return true;
                    else 
                    {
                        if (i % 2 == 0)
                            return isUglyNumber(i / 2);
                        else if (i % 3 == 0)
                            return isUglyNumber(i / 3);
                        else if (i % 5 == 0)
                            return isUglyNumber(i / 5);
                        return false;
                    }
                }
            }

        }

    }
}
