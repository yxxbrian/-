using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算字符个数
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            inputStr = inputStr.ToLower();
            int inputChar = Console.Read();
            if (inputChar >= 'A' && inputChar <= 'Z')
                inputChar -= ('A' - 'a');
            int count = 0;
            foreach (char c in inputStr)
            {
                if (c == inputChar)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();


        }
    }
}
