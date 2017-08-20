using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> inputInts = new List<int>();
            foreach (string str in inputs)
            {
                inputInts.Add(int.Parse(str));
            }

            int minDistance = int.MaxValue;
            int Person_lower = 0;
            int Person_higher = 0;

            for (int i = 0; i < inputInts.Count-1; i++)
            {
                for (int j = i+1; j < inputInts.Count; j++)
                {
                    int currentDistance = Math.Abs(inputInts[i] - inputInts[j]);
                    if (currentDistance < minDistance)
                    {
                        int lowerOne = inputInts[i] < inputInts[j] ? inputInts[i] : inputInts[j];
                        int higherOne = inputInts[i] < inputInts[j] ? inputInts[j] : inputInts[i];
                        minDistance = currentDistance;
                        Person_lower = lowerOne;
                        Person_higher = higherOne;
                    }
                    else if (currentDistance == minDistance)
                    {
                        int lowerOne = inputInts[i] < inputInts[j] ? inputInts[i] : inputInts[j];
                        int higherOne = inputInts[i] < inputInts[j] ? inputInts[j] : inputInts[i];
                        if (higherOne > Person_higher) 
                        {
                            Person_lower = lowerOne;
                            Person_higher = higherOne;
                        }
                    }
                }
            }
            Console.Write(Person_lower + " " + Person_higher);

        }
    }
}
