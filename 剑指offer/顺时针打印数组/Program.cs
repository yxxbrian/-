using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 顺时针打印矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        //23 ms	2792K
        class Solution
        {

            public List<int> printMatrix(int[][] matrix)
            {
                // write code here
                if(matrix.Length == 0 || matrix[0].Length == 0)
                    return new List<int>();
                List<int> res = new List<int>();
                getCircle(res, matrix,0, matrix[0].Length, matrix.Length);
                return res;
            }

            public void getCircle(List<int> result, int[][] matrix, int circleIndex, int width, int height) 
            {
                if (width > 1 && height > 1)
                {
                    for (int i = 0; i < width - 1; i++)
                    {
                        result.Add(matrix[circleIndex][circleIndex + i]);
                    }
                    for (int i = 0; i < height - 1; i++)
                    {
                        result.Add(matrix[circleIndex + i][circleIndex + width - 1]);
                    }
                    for (int i = width - 1; i > 0; i--)
                    {
                        result.Add(matrix[circleIndex + height - 1][circleIndex + i]);
                    }
                    for (int i = height - 1; i > 0; i--)
                    {
                        result.Add(matrix[circleIndex + i][circleIndex]);
                    }
                    getCircle(result, matrix, ++circleIndex, width - 2, height - 2);
                }
                else if (width == 1) 
                {
                    for (int i = 0; i <= height - 1; i++)
                    {
                        result.Add(matrix[circleIndex + i][circleIndex + width - 1]);
                    }
                    return;
                }
                else if (height == 1)
                {
                    for (int i = 0; i <= width - 1; i++)
                    {
                        result.Add(matrix[circleIndex][circleIndex + i]);
                    }
                    return;
                }
            }


        }





    }
}
