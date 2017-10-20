using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 翻转序列
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] splits = str.Split(new char[] { ' ' });
            str = splits[0];
            int m = int.Parse(splits[1]);

            for (int i = 0; i < (int)(str.Length / (2 * m)); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    char c = str[(int)(i * 2 * m + m - 1 - j)];
                    Console.Write(c);
                }
                for (int j = 0; j < m; j++)
                    Console.Write(str[(int)(i * 2 * m + m + j)]);
            }
            int tmpLength = str.Length % (2 * m);
            if (tmpLength <= m)
            {
                for (int i = 0; i < tmpLength; i++)
                    Console.Write(str[str.Length -1 - i]);
            }
            else 
            {
                int bas = str.Length / (2 * m) * (2 * m);
                for (int i = 0; i < m; i++)
                {
                    Console.Write(str[bas + m - 1 - i].ToString());
                }
                for (int i = bas + m; i < str.Length; i++)
                {
                    Console.Write(str[i].ToString()); 
                }
            }
            Console.ReadLine();
        }
    }
}
