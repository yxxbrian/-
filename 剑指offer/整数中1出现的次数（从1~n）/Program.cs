using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 求出1~13的整数中1出现的次数,并算出100~1300的整数中1出现的次数？
 * 为此他特别数了一下1~13中包含1的数字有1、10、11、12、13因此共出现6次,
 * 但是对于后面问题他就没辙了。
 * ACMer希望你们帮帮他,并把问题更加普遍化,
 * 可以很快的求出任意非负整数区间中1出现的次数。
 */

namespace 整数中1出现的次数_从1_n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int res = sol.NumberOf1Between1AndN_Solution(10);
        }
    }

    class Solution
    {
        public int NumberOf1Between1AndN_Solution(int n)
        {
            // write code here
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int cur = NumberOf1InNum(i);
                count += cur;
            }
            return count;
        }

        private int NumberOf1InNum(int num) 
        {
            int count = 0;
            while (num != 0)
            {
                int low = num % 10;
                num /= 10;
                if (low == 1)
                    count++;
            }
            return count;
        }

    }


}
