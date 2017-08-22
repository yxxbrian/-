using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 背包问题
{

    /*
    8 110
    1 11
    11 21
    21 31
    23 33
    33 43
    43 43
    45 55
    55 65
    */
     
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            string[] splits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            N = int.Parse(splits[0]);
            M = int.Parse(splits[1]);
            int[] weights = new int[N+1];
            int[] values = new int[N+1];
            int[][] dp = new int[N+1][];
            for(int i=0;i<= N;i++)
                dp[i] = new int[M+1];

            for (int i = 1; i <= N; i++)
            {
                string[] strsplits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                weights[i] = int.Parse(strsplits[0]);
                values[i] = int.Parse(strsplits[1]);
            }


            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                {
                    if (weights[i]<=j &&  dp[i - 1][j - weights[i]] + values[i] > dp[i - 1][j])
                        dp[i][j] = dp[i - 1][j - weights[i]] + values[i];
                    else
                        dp[i][j] = dp[i - 1][j];
                }


            Console.WriteLine(dp[N][M]);
            Console.ReadLine();

        }




    }
}
