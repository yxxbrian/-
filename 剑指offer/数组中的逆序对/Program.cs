using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 在数组中的两个数字，如果前面一个数字大于后面的数字，
 * 则这两个数字组成一个逆序对。
 * 输入一个数组,求出这个数组中的逆序对的总数P。
 * 并将P对1000000007取模的结果输出。 
 * 即输出P%1000000007
 */
namespace 数组中的逆序对
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 0 };
            int res = new Solution().InversePairs(arrayList.ToArray<int>());
        }
    }

    //Not Accepted
    class Solution
    {
        public int InversePairs(int[] data)
        {
            // write code here
            int count = 0;
            if (data.Length <= 1)
                return 0;
            for (int i = 1; i < data.Length; i++)
            {
                int pos = FindPosition(ref data, data[i], 0, i-1);
                count += pos;
                if (count >= 1000000007)
                    count %= 1000000007;
            }
            return count;
        }

        private int FindPosition(ref int[] array, int num,int start,int end)
        {
            int head = start;
            int tail = end;
            while (head <= tail) 
            {
                int mid_index = (head + tail) / 2;
                if (num < array[mid_index])
                    tail = mid_index - 1;
                else
                    head = mid_index + 1;
            }
            for (int i = end+1; i > head; i--)
                array[i] = array[i - 1];
            array[head] = num;
            return (end - start + 1 - (head - start));
        }

    }

}
