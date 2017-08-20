using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//DP
namespace 远景能源_PAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            while (!string.IsNullOrEmpty(inputStr = Console.ReadLine()))
            {
                int length = inputStr.Length;
                char[] inputChars = inputStr.ToCharArray();
                int p = 0;
                int pa = 0; 
                int pat = 0;
                foreach (char c in inputStr)
                {
                    if (c == 'P')
                        p++;
                    else if (c == 'A')
                    {
                        pa += p;
                        pa %= 1000000007;
                    }
                    else if (c == 'T')
                    {
                        pat += pa;
                        pat %= 1000000007;
                    }
                }
                Console.WriteLine(pat);
            }
        }
    }
}
