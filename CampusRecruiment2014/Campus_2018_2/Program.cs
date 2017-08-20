using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campus_2018_2
{
    
    class Program
    {
       static List<string> Table = new List<string>() 
            {
                "F","G","R","S","T","L","M","N","O","P",
                "Q","W","X","Y","Z","U","A","G","H","I",
                "J","K","B","C","D","E","I","m","n","o",
                "p","i","j","k","f","g","h","a","b","c",
                "d","e","q","r","w","x","y","z","s","t",
                "u","v"
            };

        static void Main(string[] args)
        {
            
            string inputStr;
            while (!string.IsNullOrEmpty(inputStr = Console.ReadLine())) 
            {
                Console.Write(ParseString(inputStr));
            }
            Console.ReadLine();
        }

        public static string ParseString(string inputStr)
        {
            string res = "";
            string[] inputStrSplits = inputStr.Split(new char[] { '#' });
            List<int> nums = new List<int>();
            foreach (string str in inputStrSplits)
            {
                nums.Add(getIntFromStr(str));
            }
            if (isNumsValid(nums))
            {
                foreach (int n in nums)
                {
                    res += Table[n];
                    //Console.Write(Table[n]);
                }
                res += "\n";
                //Console.WriteLine();
            }
            else
            {
                res += "ERROR";
                //Console.WriteLine("ERROR");
            }
            return res;
        }
        static bool isNumsValid(List<int> nums)
        {
            bool valid = true;
            foreach (int n in nums)
            {
                if (n < 0 || n > 51)
                    valid = false;
            }
            return valid;
        }
        static int getIntFromStr(string str) 
        {
             List<int> ZeroOnes = new List<int>();
            for (int i = 0; i < str.Length;i++ )
            {
                char c = str[i];
                if (c == '.')
                    ZeroOnes.Add(1);
                else if (c == '-')
                    ZeroOnes.Add(0);
                else
                    return -1;
            }
            int num = 0;
            for (int i = 0; i < ZeroOnes.Count; i++)
            {
                num += ZeroOnes[i] * (int)Math.Pow(2, ZeroOnes.Count-1 - i);
            }
            return num;
        }

    }
}
