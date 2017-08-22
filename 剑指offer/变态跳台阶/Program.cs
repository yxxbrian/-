using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 变态跳台阶
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        class Solution
        {
            public int jumpFloorII(int number)
            {
                int[] dp = new int[number + 1];
                dp[0] = 1;
                dp[1] = 1;
                // write code here
                for (int i = 2; i <= number; i++)
                {
                    for (int j = i; j >= 1 ; j--)
                    {
                        dp[i] += dp[i - j];
                    }
                }
                return dp[number];
            }
        }

    }
}
