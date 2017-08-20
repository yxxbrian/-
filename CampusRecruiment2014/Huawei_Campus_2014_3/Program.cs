using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            bool valid = true;
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        valid = false;
                        break;
                    }
                    char peek = stack.Pop();
                    if ((peek == '(' && c == ')') || (peek == '[' && c == ']') || (peek == '{' && c == '}')) 
                    { }
                    else
                        valid = false;
                }
            }
            if (stack.Count > 0)
                valid = false;
            Console.Write(valid ? 0 : 1);
            Console.ReadKey();
        }
    }
}
