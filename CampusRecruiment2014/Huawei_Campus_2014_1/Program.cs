using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
            List<int> inputInts = new List<int>();
            foreach (string str in inputs)
            {
                inputInts.Add(int.Parse(str));
            }
            int min = inputInts[0];
            int max = inputInts[0];
            foreach (int i in inputInts)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
            }
            int count = 0;
            foreach (int i in inputInts)
            {
                if (i != min && i != max)
                    count++;
            }
            Console.Write(count);

            //
            Console.ReadKey();
        }
    }
}
