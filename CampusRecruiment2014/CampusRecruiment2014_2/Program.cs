﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusRecruiment2014_2
{
    /*
     一条长廊里依次装有n(1 ≤ n ≤ 65535)盏电灯，从头到尾编号1、2、3、…n-1、n。每盏电灯由一个拉线开关控制。开始，电灯全部关着。
    有n个学生从长廊穿过。第一个学生把号码凡是1的倍数的电灯的开关拉一下；接着第二个学生把号码凡是2的倍数的电灯的开关拉一下；
    接着第三个学生把号码凡是3的倍数的电灯的开关拉一下；如此继续下去，最后第n个学生把号码凡是n的倍数的电灯的开关拉一下。
    n个学生按此规定走完后，长廊里电灯有几盏亮着。
    注：电灯数和学生数一致。

     */



    class Program
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] islightsOn = new bool[n+1];
            for (int i = 1; i <= n; i++)
            {
                islightsOn[i] = false;
            }
            for (int stuIndex = 1; stuIndex <= n; stuIndex++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j % stuIndex == 0)
                        islightsOn[j] = !islightsOn[j];
                }
            }
            Console.Write(countLightOnNum(islightsOn));
            Console.ReadKey();
        }

        static int countLightOnNum(bool[] isLightsOn) 
        {
            int count = 0;
            for (int i = 1; i < isLightsOn.Length;i++ )
            {
                if (isLightsOn[i] == true)
                    count++;
            }
            return count;
        }

    }
}
