using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campus_2018_2
{
    class _70_pass
    {
        /*
         
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campus_2018_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Table = new List<string>() 
            {
                "F","G","R","S","T","L","M","N","O","P",
                "Q","W","X","Y","Z","U","A","G","H","I",
                "J","K","B","C","D","E","I","m","n","o",
                "p","i","j","k","f","g","h","a","b","c",
                "d","e","q","r","w","x","y","z","s","t",
                "u","v"
            };

            string inputStr;
            while (!string.IsNullOrEmpty(inputStr = Console.ReadLine())) 
            {
                string res="";
                string convertStringChar="";
                bool valid = true;
                string[] inputStrSplits = inputStr.Split(new char[] { '#' },StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in inputStrSplits)
                {
                    if (str.Trim() == "")
                        continue;
                    int num = getIntFromStr(str);
                    
                    if (num >= 0 && num < Table.Count)
                    {
                        convertStringChar = Table[num];
                        res += convertStringChar;
                    }
                    else
                    {
                        convertStringChar = "ERROR";
                        res +="ERROR";
                        valid = false;
                        break;
                    }
                }
                if (valid)
                    Console.WriteLine(res);
                else
                    Console.WriteLine("ERROR");
            }
            Console.ReadLine();

        }

        static int getIntFromStr(string str) 
        {
            int[] ZeroOnes = new int[str.Length];
            for (int i = 0; i < str.Length;i++ )
            {
                char c = str[i];
                if (c == '.')
                    ZeroOnes[i] = 1;
                else if (c == '-')
                    ZeroOnes[i] = 0;
                else
                    return -1;
            }
            int num = 0;
            for (int i = 0; i < ZeroOnes.Length; i++)
            {
                num += ZeroOnes[i] * (int)Math.Pow(2, ZeroOnes.Length-1 - i);
            }
            return num;
        }

    }
}


         
         
         
         
         
         
         
         
         
         
         
         
         */



    }
}
