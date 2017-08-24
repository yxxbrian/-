using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 
 给定一个double类型的浮点数base和int类型的整数exponent。求base的exponent次方。
 
 */


namespace 数值的整数次方
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //我的方法，为啥无法通过，显示应该为8.00000，不该为8 ???!!!
    /*
    class Solution
    {
        public double Power(double thebase, int exponent)
        {
            // write code here
            return System.Math.Pow(thebase, exponent);
        }
    }
    */

    class Solution
    {
        public double Power(double thebase, int exponent)
        {
            // write code here
            double res = 1;
            if (exponent == 0)
                return 1;
            else if (exponent > 0)
            {
                for (int i = 0; i < exponent; i++)
                    res *= thebase;
            }
            else
            {
                if (thebase == 0)
                {
                    Console.WriteLine("指数<0时，底数无法为负值");
                }
                else 
                {
                    for (int i = 0; i > exponent; i++)
                        res / thebase;
                }
            }
            return res;
        }
    }


}
