using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 统计一个数字在排序数组中出现的次数。
 */
namespace 数字在排序数组中出现的次数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution2 sol = new Solution2();
            int[] dd = new int[] { 1, 2, 3, 3, 3, 3, 4, 5 };
            int res = sol.GetNumberOfK(dd, 3);
        }
    }

    //24 ms	2660K
    class Solution
    {
        public int GetNumberOfK(int[] data, int k)
        {
            // write code here
            int count = 0;
            if (data.Length == 0)
                return 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (k == data[i])
                    count++;
            }
            return count;
        }
    }


    //23 ms	2656K
    class Solution1
    {
        public int GetNumberOfK(int[] data, int k)
        {
            // write code here
            if (data.Length == 0)
                return 0;
            int start = 0;
            int end = data.Length - 1;
            int mid_index = 0;
            while (true)
            {
                if (start > end)
                    break;
                mid_index = (start + end) / 2;
                if (data[mid_index] == k)
                    break;
                else 
                {
                    if (k < data[mid_index])
                        end = mid_index - 1;
                    else if (k > data[mid_index])
                        start = mid_index + 1;
                }
            }
            int count = 0;
            if(data[mid_index] == k)
                count = 1;
            for (int i = 1; i < data.Length; i++)
            {
                bool firstFlag = false;
                bool secondFlag = false;
                if (mid_index - i >= 0 && data[mid_index - i] == k)
                {
                    firstFlag = true;
                    count++; 
                }
                if (mid_index + i < data.Length && data[mid_index + i] == k)
                {
                    secondFlag = true;
                    count++; 
                }
                if (firstFlag == false && secondFlag == false)
                    break;
            }
            return count;
        }
    }


    class Solution2
    {
        public int GetNumberOfK(int[] data, int k) 
        {
            if (data.Length == 0)
                return 0;
            int left = getLeft(data, k);
            int right = getRight(data, k);
            if (left >= 0)
                return right - left + 1;
            else
                return 0;
        }

        private int getLeft(int[] data, int k) 
        {
            int left = 0;
            int right = data.Length - 1;
            while (left < right)
            {
                int mid_index = (left + right) >> 1;
                if (k > data[mid_index])
                    left = mid_index + 1;
                else
                    right = mid_index;
            }
            if (data[left] == k)
                return left;
            else
                return -1;
        }

        private int getRight(int[] data, int k)
        {
            int left = 0;
            int right = data.Length - 1;
            while (left < right)
            {
                int mid_index = (left + right+1) >> 1;
                if (k < data[mid_index])
                    right = mid_index - 1;
                else
                    left = mid_index;
            }
            if (data[left] == k)
                return left;
            else
                return -1;
        }

    }

}
