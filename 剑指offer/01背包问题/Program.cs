using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01背包问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            string[] splits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            N = int.Parse(splits[0]);
            M = int.Parse(splits[1]);
            int[] weights = new int[N + 1];
            int[] values = new int[N + 1];
            int[][] dp = new int[N+1][];
            for (int i = 0; i < N + 1; i++)
                dp[i] = new int[M + 1];
            for (int i = 1; i <= N; i++)
            {
                string[] strsplits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                weights[i] = int.Parse(strsplits[0]);
                values[i] = int.Parse(strsplits[1]);
            }


            for(int i=1;i<N+1;i++)
                for (int j = 1; j < M + 1; j++)
                {
                    if (weights[i] < j)
                    {
                        dp[i][j] = Math.Max(dp[i-1][j],dp[i-1][j-weights[i]]+values[i]);
                    }
                }
            Console.WriteLine(dp[N][M]);
            Console.ReadLine();

        }
    }
}
