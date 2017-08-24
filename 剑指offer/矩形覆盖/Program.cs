using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 矩形覆盖
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        class Solution
        {
            public int rectCover(int number)
            {
                // write code here
                if (number == 0)
                    return 0;
                if (number == 1)
                    return 1;
                int first = 1, second = 1,tmp = 0 ;
                for (int i = 2; i <= number; i++)
                {
                    tmp = first + second;
                    second = first;
                    first = tmp;
                }
                return first;
            }
        }


    }
}
