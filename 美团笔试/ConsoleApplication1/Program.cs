using System;

namespace Meituan_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int curLv = 0;
            int numCount = int.Parse(Console.ReadLine());
            int[] nums = new int[numCount];
            string[] strSplits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(strSplits[i]);
            int K = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length + 1];
            int lv = 1;
            while (lv <= nums.Length)
            {
                for (int index = 1; index <= nums.Length - lv + 1; index++)
                {
                    sum[index] = sum[index] + nums[lv + index - 2];
                    if (sum[index] % K == 0 && lv > curLv)
                        curLv = lv;
                }
                lv++;
            }

            Console.WriteLine(curLv);
            Console.ReadLine();

        }
    }
}
