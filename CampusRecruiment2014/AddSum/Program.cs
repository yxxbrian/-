using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            while(!string.IsNullOrEmpty(inputStr = Console.ReadLine()))
            {
                string[] strSplits = inputStr.Split(new char[] { ' ' });
                int sum = 0;
                foreach (string str in strSplits)
                {
                    sum += int.Parse(str);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
