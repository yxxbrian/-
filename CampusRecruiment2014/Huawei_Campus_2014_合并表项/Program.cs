using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_合并表项
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<int, int> Table = new Dictionary<int, int>();
            for (int i = 0; i < num; i++)
            {
                string str = Console.ReadLine();
                string[] strsplits = str.Split(new char[] { ' ' });
                int index = int.Parse(strsplits[0]);
                int val = int.Parse(strsplits[1]);
                if (Table.ContainsKey(index))
                    Table[index] += val;
                else
                {
                    Table.Add(index, val);
                }
            }
            Table = Table.OrderBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
            foreach(KeyValuePair<int,int> item in Table)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            //Console.ReadKey();

        }

    }
}
