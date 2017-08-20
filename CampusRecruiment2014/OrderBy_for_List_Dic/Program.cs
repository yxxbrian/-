using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderBy_for_List_Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";
            List<int> nums = new List<int>();
            int[] num_array = new int[5];
            int index = 0;
            while (!string.IsNullOrEmpty(inputStr = Console.ReadLine()))
            {
                num_array[index++] = (int.Parse(inputStr));
            }
            foreach (int i in num_array)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("Order by num:");
            //nums = nums.OrderBy(o=>o).ToList();
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            num_array = num_array.OrderBy(o => o).ToArray();
            foreach (int i in num_array)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


            
        }
    }
}
