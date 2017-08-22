using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 斐波那契数列
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            int result = Fibonacci(index);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //运行时间：25ms 占用内存：2632k
        /*
        public int Fibonacci(int n)
        {
            // write code here
            int index = n;
            int[] array = new int[40];
            int tmp = 1;
            array[tmp] = 1;
            while (tmp++ < index)
            {
                array[tmp] = array[tmp - 1] + array[tmp - 2];
            }
            return array[index];
        }
        */
        public int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            int num1 = 1;
            int num2 = 0;
            int tmp = 0;
            for (int i = 2; i <= n; i++)
            {
                tmp = num1 + num2;
                num2 = num1;
                num1 = tmp;
            }
            return num1;
        }



    }
}
