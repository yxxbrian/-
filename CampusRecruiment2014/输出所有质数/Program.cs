using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 输出所有质数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (isZhishu(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static bool isZhishu(int n) 
        {
            if(n<2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if ((double)n / i == (int)((double)n / i))
                    return false;
            }
            return true;

        }

    }
}
