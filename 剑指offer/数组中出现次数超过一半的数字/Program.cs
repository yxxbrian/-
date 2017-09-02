using System.Collections.Generic;
/*
 * 数组中有一个数字出现的次数超过数组长度的一半，请找出这个数字。
 * 例如输入一个长度为9的数组{1,2,3,2,2,2,5,4,2}。
 * 由于数字2在数组中出现了5次，超过数组长度的一半，因此输出2。
 * 如果不存在则输出0。
 */
namespace 数组中出现次数超过一半的数字
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Solution
        {
            public int MoreThanHalfNum_Solution(int[] numbers)
            {
                // write code here
                Dictionary<int, int> summary = new Dictionary<int, int>();
                double half = numbers.Length/2.0;
                foreach (int val in numbers)
                {
                    if (Push(val, summary, half))
                        return val;
                }
                return 0;
            }
            private bool Push(int number, Dictionary<int, int> summary,double half)
            {
                if (!summary.ContainsKey(number))
                    summary.Add(number, 0);
                summary[number] += 1;
                if (summary[number] > half)
                    return true;
                else
                    return false;
            }

        }


    }
}
