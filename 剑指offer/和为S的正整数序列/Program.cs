using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 小明很喜欢数学,有一天他在做数学作业时,要求计算出9~16的和,他马上就写出了正确答案是100。
 * 但是他并不满足于此,他在想究竟有多少种连续的正数序列的和为100(至少包括两个数)。
 * 没多久,他就得到另一组连续正数和为100的序列:18,19,20,21,22。
 * 现在把问题交给你,你能不能也很快的找出所有和为S的连续正数序列? Good Luck!
 */
namespace 和为S的正整数序列
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            List<List<int>> res = sol.FindContinuousSequence(100);
        }
    }

    class Solution
    {
        public List<List<int>> FindContinuousSequence(int sum)
        {
            // write code here
            List<List<int>> result = new List<List<int>>();
            List<int> sum_array = new List<int>();
            sum_array.Add(0);
            for (int i = 1; i <= (sum + 1) / 2; i++) 
            {
                sum_array.Add(sum_array[i - 1] + i);
            }
            int top = (sum+1)>>1;
            int high = top, low = high - 2;
            while (high > 1 && low>=0)
            {
                while (low>=0 && sum_array[high] - sum_array[low] < sum)
                {
                    low--; 
                }
                if (low>=0 && sum_array[high] - sum_array[low] == sum)
                {
                    List<int> tmpList = new List<int>();
                    for (int i = low + 1; i <= high; i++)
                        tmpList.Add(i);
                    result.Insert(0,tmpList);
                }
                high--;
            }
            return result;
        }
    }

}
