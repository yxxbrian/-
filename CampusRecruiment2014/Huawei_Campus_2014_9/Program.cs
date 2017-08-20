using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            Stack<char> charStack = new Stack<char>();
            bool validate = true;
            int char_left_count = 0;
            int char_right_count = 0;
            for (int i=0;i<inputStr.Length;i++)
            {
                char c = inputStr[i];
                if (c == '(' || c == ')')
                {
                    if (c == '(')
                    {
                        charStack.Push('(');
                        char_left_count++;
                    }
                    else
                    {
                        char_right_count++;
                        if (charStack.Count>0 && charStack.Pop() == '(' && (charStack.Count > 0 || charStack.Count == 0 && i == inputStr.Length - 1))
                        {
                            //pipei
                        }
                        else
                        {
                            validate = false;
                        }
                    }
                }
            }


            //out
            Console.Write(validate?"RIGHT":"WRONG");
            Console.Write(" "+char_left_count);
            Console.Write(" " + char_right_count);
            Console.ReadKey();
        }
    }
}
