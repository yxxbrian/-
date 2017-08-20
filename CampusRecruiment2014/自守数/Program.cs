using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 自守数
{
    class Program
    {
        static void Main(string[] args)
        {
            int upNum = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=1;i<upNum;i++)
            {
                if (isZishoushu(i))
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }

        static bool isZishoushu(int num) 
        {
            int powNum = (int)Math.Pow(num, 2);
            if (powNum.ToString().EndsWith(num.ToString()))
                return true;
            else
                return false;
        }

    }
}
