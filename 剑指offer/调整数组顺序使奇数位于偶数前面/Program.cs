using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 输入一个整数数组，实现一个函数来调整该数组中数字的顺序，
 * 使得所有的奇数位于数组的前半部分，
 * 所有的偶数位于位于数组的后半部分，
 * 并保证奇数和奇数，
 * 偶数和偶数之间的相对位置不变。
 */

namespace 调整数组顺序使奇数位于偶数前面
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    class Solution1
    {
        public int[] reOrderArray(int[] array)
        {
            // write code here
            int[] dst = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                    dst[index++] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    dst[index++] = array[i];
            }
            return dst;
        }
        
    }




    //27 ms	2652K	
    class Solution
    {
        public int[] reOrderArray(int[] array)
        {
            // write code here
            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] % 2 == 0 && array[i + 1] % 2 == 1)
                    {
                        exchange(array, i, i + 1);
                        changed = true;
                    }
            }
            return array;
        }
        public void exchange(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }


}
