using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 最长数字串
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int max = 0;
            int tempMax = 0;
            foreach (char c in inputStr)
            {
                if (c >= '0' && c <= '9')
                {
                    tempMax++;
                    if (tempMax > max)
                        max = tempMax;
                }
                else
                {
                    tempMax = 0;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();


        }
    }
}
