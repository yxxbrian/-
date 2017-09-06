using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * HZ偶尔会拿些专业问题来忽悠那些非计算机专业的同学。
 * 今天测试组开完会后,他又发话了:在古老的一维模式识别中,
 * 常常需要计算连续子向量的最大和,当向量全为正数的时候,问题很好解决。
 * 但是,如果向量中包含负数,是否应该包含某个负数,并期望旁边的正数会弥补它呢？\
 * 例如:{6,-3,-2,7,-15,1,2,2},连续子向量的最大和为8(从第0个开始,到第3个为止)。
 * 你会不会被他忽悠住？(子向量的长度至少是1) 
 */
namespace 最大子向量
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    //运行时间： 20 ms 占用内存：2660K
    class Solution
    {
        public int FindGreatestSumOfSubArray(int[] array)
        {
            // write code here
            if (array.Length == 0)
                return 0;
            int max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] + sum > array[i])
                    sum += array[i];
                else
                    sum = array[i];
                if (sum > max)
                    max = sum;
            }
            return max;
        }
    }

}
