using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 在一个二维数组中，每一行都按照从左到右递增的顺序排序，每一列都按照从上到下递增的顺序排序。
 * 请完成一个函数，输入这样的一个二维数组和一个整数，判断数组中是否含有该整数。
 
 */

namespace 二维数组查找树
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        // 38 ms	6116K
        public static bool Find(int target, int[][] array)
        {
            // write code here
            if (array.Length > 0 && array[0].Length > 0)
            {
                int curX = 0;
                int curY = array[0].Length-1;
                while (curX >= 0 && curX < array.Length && curY >= 0 && curY < array[0].Length)
                {
                    int curNum = array[curX][curY];
                    if(target == curNum)
                        return true;
                    else if (target < curNum)
                    {
                        curY--;
                        continue;
                    }
                    else if(target>curNum)
                    {
                        curX++;
                        continue;
                    }
                }
                return false;
            }
            else
                return false;
        }





        //第一次解法，811 ms	5880K
        /*
        public static bool Find(int target, int[][] array)
        {
            // write code here
            finded = false;
            if(array.Length >0 && array[0].Length>0)
                Find(target, array, 0, 0);
            return finded;
        }

        static bool finded = false;
        public static void Find(int target, int[][] array, int curX, int curY)
        {
            if (finded == false)
            {
                if (array[curX][curY] == target)
                {
                    finded = true;
                    return;
                }
                else
                {
                    if (array[curX][curY] > target)
                        return;
                    else
                    {
                        if (curX + 1 < array.Length)
                        {
                            Find(target, array, curX + 1, curY);
                        }
                        if (curY + 1 < array[0].Length)
                        {
                            Find(target, array, curX, curY + 1);
                        }
                    }
                }
            }
        }
         */
    }
}
