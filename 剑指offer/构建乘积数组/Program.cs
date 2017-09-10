using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 给定一个数组A[0,1,...,n-1],请构建一个数组B[0,1,...,n-1],
 * 其中B中的元素B[i]=A[0]*A[1]*...*A[i-1]*A[i+1]*...*A[n-1]。不能使用除法。
 */
namespace 构建乘积数组
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Solution
    {
        public int[] multiply(int[] A)
        {
            // write code here
            int[] B1 = new int[A.Length];
            int[] B2 = new int[A.Length];
            int[] B = new int[A.Length];
            B1[0] = 1;
            for (int i = 1; i < A.Length; i++)
                B1[i] = B1[i - 1] * A[i-1];
            B2[A.Length - 1] = 1;
            for (int i = A.Length - 2; i >= 0; i--)
            {
                B2[i] = B2[i + 1] * A[i + 1];
                B[i] = B1[i] * B2[i];
            }
            return B;
        }
    }

}
