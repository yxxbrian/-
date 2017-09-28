using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 可信区间
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> countTable = new Dictionary<int,int>();
            for(int i=-50;i<=50;i++)
            {
                countTable.Add(i,0);
            }

            string str = Console.ReadLine();
            string[] splits = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int totalNum = int.Parse(splits[0]);
            int zhixinnum = int.Parse(splits[1]);


            for (int i = 0; i < totalNum; i++)
            {
                str = Console.ReadLine();
                splits = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int num0 = int.Parse(splits[0]);
                int num1 = int.Parse(splits[1]);
                for (int j = num0; j <= num1; j++)
                    countTable[j]++;
            }

            int minLine = 0;
            bool foundMin = false;
            for (int i = -50; i <= 50; i++)
            {
                if (countTable[i] >= zhixinnum)
                {
                    minLine = i;
                    foundMin = true;
                    break;
                }
            }
            if (foundMin == false) 
            {
                Console.WriteLine("error");
                return;
            }


            int maxLine = 0;
            for (int i = 50; i >= -50; i--)
            {
                if (countTable[i] >= zhixinnum)
                {
                    maxLine = i;
                    break;
                }
            }

            Console.WriteLine(minLine + " " + maxLine);
            Console.ReadLine();

        }
    }
}
