using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10] { 10, 18, 4, 3, 6, 12, 1, 9, 18, 8 };
            int a = nums[10];
            qsort1(nums, 0, 9);
        }



        public static void qsort1(int[] a, int p, int r)
        {
            if (p >= r)
                return;
            int j = p;
            for (int i = p + 1; i <= r; i++)
            {
                if (a[i] < a[p])
                    swap(a, i, ++j);
            }
            swap(a, j, p);
            qsort1(a, p, j - 1);
            qsort1(a, j + 1, r);
        }
        public static void swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }


    }
}
