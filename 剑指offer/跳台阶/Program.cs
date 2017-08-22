using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 跳台阶
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int jumpFloor(int number)
        {
            // write code here
            if (number == 1 || number == 0)
                return 1;
            int dp_1 = 1;
            int dp_2 = 1;
            int tmp = 0;
            for (int i = 2; i <= number; i++)
            {
                tmp = dp_1 + dp_2;
                dp_2 = dp_1;
                dp_1 = tmp;
            }
            return dp_1;
        }


    }
}
