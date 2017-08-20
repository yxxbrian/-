using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//未通过，不知道题目需求
namespace 数组中重复的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1,2,4,5,2,7};
            int[] duplication = new int[numbers.Length];
            duplicate(numbers,duplication);
            
            Console.ReadLine();
        }


        public static bool duplicate(int[] numbers, int[] duplication)
        {
            // write code here
            for (int i = 0; i < numbers.Length; i++)
            {
               duplication[numbers[i]]++;
            }
            int[] res = new int[numbers.Length];
            int j=0;
            for (int i = 0; i < duplication.Length; i++)
            {
                if (duplication[i] > 1)
                    res[j++] = duplication[i];
            }
            duplication = res;
            return true;
        }

    }
}
