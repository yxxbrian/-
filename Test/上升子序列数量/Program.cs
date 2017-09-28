using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上升子序列数量
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            List<int> list = new List<int>();
            str = Console.ReadLine();
            string[] splits = str.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < num; i++)
                list.Add(int.Parse(splits[i]));



        }
    }
}
