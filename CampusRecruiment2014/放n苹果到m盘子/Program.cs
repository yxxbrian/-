using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 放m苹果到n盘子
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int apple_M = int.Parse(Console.ReadLine());
            int plate_N = int.Parse(Console.ReadLine());
            int num = compute(apple_M, plate_N);
            Console.WriteLine(num);
            Console.ReadLine();

        }

        static int compute(int m,int n) 
        {
            if (m <= 1 || n <= 1)
                return 1;
            if (m < n)
            {
                return compute(m, m);
            }
            else
                return compute(m, n - 1) + compute(m - n, n);
        }


    }
}
