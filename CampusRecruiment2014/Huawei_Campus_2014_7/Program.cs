using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "";

            string inputStr = Console.ReadLine();
            if (inputStr.StartsWith("-"))
            {
                flag = "-";
                inputStr = inputStr.Substring(1);
            }
            List<char> notDulplatedChars = new List<char>();
            foreach (char c in inputStr)
            {
                if (notDulplatedChars.Count == 0 || (notDulplatedChars.Count > 0 && c != notDulplatedChars[notDulplatedChars.Count - 1]))
                    notDulplatedChars.Add(c);
            }
            
            //out
            Console.Write(flag);
            for(int i = notDulplatedChars.Count-1;i>=0;i--)
            {
                Console.Write(notDulplatedChars[i]);
            }
            Console.ReadLine();
        }
    }
}
