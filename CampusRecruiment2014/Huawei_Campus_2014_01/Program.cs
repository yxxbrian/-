using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allMoneyType = new int[]{ 1,5,10,20,50,100};
            int[] backNum = new int[allMoneyType.Length];
            int GiveMoney = int.Parse(Console.ReadLine());
            int ShopMoney = int.Parse(Console.ReadLine());
            int back = GiveMoney - ShopMoney;
            
            for (int i = allMoneyType.Length - 1; i >= 0; i--)
            {
                backNum[i] = back / allMoneyType[i];
                back %= allMoneyType[i];
            }

            for (int i = 0; i < backNum.Length; i++)
            {
                if (i != 0)
                    Console.Write(" ");
                Console.Write(backNum[i]);
            }
            Console.ReadKey();

        }
    }
}
