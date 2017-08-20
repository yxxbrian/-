using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_int在内存中存储时1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int num = int.Parse(inputStr);
            int count = 0;
            while (num!=0)
            {
                count++;
                num &= (num - 1);
            }
            Console.Write(count);
            Console.ReadKey();
        }

        static void Main0(string[] args)
        {
            string inputStr = Console.ReadLine();
            int num = int.Parse(inputStr);
            int flag = num >= 0 ? 1 : -1;
            num = Math.Abs(num);
            int[] binary = new int[32];
            for (int i = 31; i >= 0; i--)
            {
                int curWei = (int)(num / Math.Pow(2, i));
                if (curWei > 0)
                    binary[i] = 1;
                else
                    binary[i] = 0;
                num %= (int)Math.Pow(2, i);
            }
            if(flag == -1)
            {
                for (int i = 31; i >= 0; i--)
                {
                    binary[i] = (binary[i]+1)%2;
                }
                int jinwei = 0;
                for (int i = 0; i < 31; i++)
                {
                    int cur = (binary[i] + ((jinwei > 0) ? 1 : 0));
                    binary[i] =  cur% 2;
                    jinwei = cur/2;
                }
            }
            int count = 0;
            for (int i = 31; i >=0;i--)
            {
                if (binary[i] > 0)
                    count++;
                //if (i != 31)
                //    Console.Write(" ");
                //Console.Write(binary[i]);
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
