using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串分割
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num-->0)
            {
                string inputStr = Console.ReadLine();
                int length = inputStr.Length;
                int group = (int)Math.Ceiling((double)length / 8);
                for (int gp = 0; gp < group; gp++)
                {
                    if (gp < group - 1)
                        Console.WriteLine(inputStr.Substring(gp * 8, 8));
                    else
                    {
                        int appendNum = group * 8 - length;
                        Console.Write(inputStr.Substring(gp * 8));
                        while (appendNum-- > 0)
                            Console.Write("0");
                        Console.WriteLine("");
                    }
                }
            }
            Console.ReadLine();


            

        }
    }
}
