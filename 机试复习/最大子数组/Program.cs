using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//dp
namespace 最大子数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];
            string str = Console.ReadLine();
            string[] strSplits = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < count; i++)
            {
                nums[i] = int.Parse(strSplits[i]);
            }
            int[] dp = new int[count];
            dp[0] = nums[0];
            int max = nums[0];
            for (int i = 1; i < count; i++)
            {
                if (dp[i - 1] + nums[i] > nums[i])
                    dp[i] = dp[i - 1] + nums[i];
                else
                    dp[i] = nums[i];
                if (dp[i] > max)
                    max = dp[i];
            }
            Console.WriteLine(max); 
            Console.ReadLine();
        }
    }
}
