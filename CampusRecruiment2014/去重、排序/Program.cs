using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 去重_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string inputStr = Console.ReadLine();
            List<int> inputIntList = new List<int>();
            string[] inputStrings = inputStr.Split(new char[] { ' ' });
            foreach (string str in inputStrings)
            {
                int val = int.Parse(str);
                if (!inputIntList.Contains(val))
                    inputIntList.Add(val);
            }

            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 0; i < inputIntList.Count - 1; i++)
                {
                    if (inputIntList[i] > inputIntList[i + 1])
                    {
                        int temp = inputIntList[i];
                        inputIntList[i] = inputIntList[i + 1];
                        inputIntList[i + 1] = temp;
                        changed = true;
                    }
                }
            }

            Console.WriteLine(inputIntList.Count);
            for(int i=0;i< inputIntList.Count;i++)
            {
                if(i!=0)
                    Console.Write(" ");
                Console.Write(inputIntList[i]);
            }
            Console.ReadLine();

        }
    }
}
