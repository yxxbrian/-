using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 输入一个递增排序的数组和一个数字S，在数组中查找两个数，
 * 是的他们的和正好是S，如果有多对数字的和等于S，输出两个数的乘积最小的。
 */
namespace 和为S的两个数字
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Solution
    {
        public List<int> FindNumbersWithSum(int[] array, int sum)
        {
            // write code here
            List<List<int>> allCandidates = new List<List<int>>();
            for (int i = 0; i < array.Length; i++)
            {
                //Binary Search
                int searchTarget = sum - array[i];
                if (BinarySearch(array, searchTarget))
                {
                    List<int> tmp = new List<int>();
                    tmp.Add(array[i]);
                    tmp.Add(searchTarget);
                    allCandidates.Add(tmp);
                }
            }
            if (allCandidates.Count == 0)
                return new List<int>();
            else 
            {
                int minMulply = allCandidates[0][0] * allCandidates[0][1];
                int minIndex = 0;
                for (int i = 1; i < allCandidates.Count; i++)
                {
                    int tmp = allCandidates[i][0] * allCandidates[i][1];
                    if (tmp < minMulply)
                    {
                        minMulply = tmp;
                        minIndex = i; 
                    }
                }
                return allCandidates[minIndex];
            }
        }

        private bool BinarySearch(int[] array, int val)
        {
            int start = 0;
            int end = array.Length-1;
            while (start < end)
            {
                int mid_index = (start + end) >> 1;
                if (val > array[mid_index])
                    start = mid_index + 1;
                else
                    end = mid_index;
            }
            if (array[start] == val)
                return true;
            return false;
        }

    }
}
