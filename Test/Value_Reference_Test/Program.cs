using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Value_Reference_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,3};
            Test_0(nums);
            Test_1(nums);

        }
        static void Test_0(int[] nums)
        {
            nums = new int[] { 3, 2, 1 };
        }

        static void Test_1(int[] nums)
        {
            nums[0]++;
        }



    }


}
