using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wangyi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] splits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> nums = new List<int>();
            for (int i = 0; i < splits.Length; i++)
            {
                int curN = int.Parse(splits[i]);
                nums.Add(i);
            }

            int min = -1;
            for(int md=1;md)

        }
    }
}
