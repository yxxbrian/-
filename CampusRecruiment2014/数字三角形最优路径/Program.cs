using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数字三角形最优路径
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNum = int.Parse(Console.ReadLine());
            int[][] matrix = new int[lineNum+1][];
            int[][] Max = new int[lineNum + 1][];
            for (int i = 1; i < lineNum + 1; i++)
            {
                matrix[i] = new int[lineNum + 1];
                Max[i] = new int[lineNum + 1];
            }

            for (int i = 1; i <= lineNum; i++)
            {
                string str = Console.ReadLine();
                string[] strSplits = str.Split(new char[]{' '});
                for (int j = 1; j <= i; j++)
                {
                    matrix[i][j] = int.Parse(strSplits[j-1]);
                }
            }
            for (int i = 1; i <= lineNum; i++)
            {
                Max[lineNum][i] = matrix[lineNum][i];
            }
            for(int line=lineNum-1;line>=1;line--)
                for (int i = 0; i <= line; i++)
                {
                    Max[line][i] = matrix[line][i] + Math.Max(Max[line + 1][i], Max[line + 1][i + 1]);
                }
            Console.WriteLine(Max[1][1]);
            Console.ReadLine();

        }
    }
}
