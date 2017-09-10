using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wangyi
{
    class Program
    {
        static void Main(string[] args)
        {
            string line0 = Console.ReadLine();
            int lineNum = int.Parse(line0);
            for (int i = 0; i < lineNum; i++)
            {
                int numCount = int.Parse(Console.ReadLine());
                string[] splits = Console.ReadLine().Split(new char[] { ' ' }/*, StringSplitOptions.RemoveEmptyEntries*/);
                
                int four_count = 0;
                int two_count = 0;
                int other_count = 0;
                foreach (string m in splits)
                {
                    int n = int.Parse(m);
                    if (n % 4 == 0)
                        four_count++;
                    else if (n % 2 == 0)
                        two_count++;
                    else
                        other_count++;
                }
                if (four_count >= other_count)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                
            }
            
        }
    }
}
