using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 十六进制转十进制
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            List<char> inputChars = new List<char>();
            foreach (char c in inputStr)
            {
                inputChars.Add(c);
            }
            int length = inputStr.Length;
            int sum = 0;
            for (int wei=0; wei <=length-1; wei++)
            {
                int currentWeiValue = 0;
                if (inputChars[wei] >= '0' && inputChars[wei] <= '9')
                    currentWeiValue = inputChars[wei] - '0';
                else if (inputChars[wei] >= 'a' && inputChars[wei] <= 'f')
                    currentWeiValue = 10 + inputChars[wei] - 'a';
                else if (inputChars[wei] >= 'A' && inputChars[wei] <= 'F')
                    currentWeiValue = 10 + inputChars[wei] - 'A';
                sum += (int)(currentWeiValue * Math.Pow(16, length - 1 - wei));
            }
            Console.Write(sum);
            Console.ReadLine();

        }
    }
}
