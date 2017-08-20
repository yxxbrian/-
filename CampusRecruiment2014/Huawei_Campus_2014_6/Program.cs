using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allKinds = new List<string>() {"Double", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};

            bool validate = true;
            string inputStr = Console.ReadLine();
            List<int> headsIndexes = new List<int>();
            List<int> numbers = new List<int>();
            for(int i =0;i<inputStr.Length;i++)
            {
                char c = inputStr[i];
                if (c >= 'A' && c <= 'Z')
                {
                    headsIndexes.Add(i);
                }
                if (!(c >= 'A' && c <= 'Z') && !(c >= 'a' && c <= 'z'))
                    validate = false;
            }
            for (int i = 0; i < headsIndexes.Count; i++)
            {
                
                string subStr;
                if (i == headsIndexes.Count - 1)
                {
                    subStr = inputStr.Substring(headsIndexes[i]);
                }
                else
                {
                    subStr = inputStr.Substring(headsIndexes[i], headsIndexes[i + 1] - headsIndexes[i]);
                }
                if (allKinds.Contains(subStr))
                {
                    if (subStr != "Double")
                    {
                        numbers.Add(allKinds.IndexOf(subStr));
                    }
                    else
                    {
                        numbers.Add(-1);
                    }
                }
                else
                {
                    validate = false;
                    break;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == -1)
                {
                    if (numbers[i + 1] != -1)
                        numbers[i] = numbers[i + 1];
                    else
                        validate = false;
                }
                    
            }

            if (!validate)
            {
                Console.Write("Error");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
