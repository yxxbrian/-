using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campus_2018_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index=1;
            int sum = 0;
            for (int i = 100; i <= 1000; i++)
            {
                if (isShuixianhuashu(i))
                {
                    sum += i;
                    Console.WriteLine("第" + index++ + "个水仙花数: " + i); 
                }
            }
            Console.WriteLine("水仙花数总和为: " + sum);
            Console.ReadLine();
        }

        static bool isShuixianhuashu(int m)
        {
            int n = m;
            int length = getWeishu(n);
            List<int> eachWei = new List<int>();
            for (int i = length - 1; i >= 0; i--)
            {
                int curWei = n / (int)Math.Pow(10, i);
                eachWei.Add(curWei);
                n %= (int)Math.Pow(10, i);
            }
            int sum = 0;
            foreach (int wei in eachWei)
            {
                sum += (int)Math.Pow(wei, length);
            }
            if (sum == m)
                return true;
            else
                return false;
        }

        static int getWeishu(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
    }
}
