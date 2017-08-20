using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int num = int.Parse(inputStr);

            for (int i = 31; i >= 0; i--)
            {
                int currentWei = (int)(num / Math.Pow(2, i));
                num %= (int)(Math.Pow(2, i));
                Console.Write(currentWei);
            }
            Console.ReadKey();
        }
    }
}
