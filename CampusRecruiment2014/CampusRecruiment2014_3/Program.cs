using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusRecruiment2014_3
{
    /*
     高级题：地铁换乘
    已知2条地铁线路，其中A为环线，B为东西向线路，线路都是双向的。经过的站点名分别如下，两条线交叉的换乘点用T1、T2表示。
    编写程序，任意输入两个站点名称，输出乘坐地铁最少需要经过的车站数量（含输入的起点和终点，换乘站点只计算一次）。
    地铁线A（环线）经过车站：
    A1 A2 A3  A4 A5 A6 A7 A8 A9 T1 A10 A11 A12 A13 T2 A14 A15 A16 A17 A18
    地铁线B(直线)经过车站：
    B1 B2 B3 B4 B5 T1 B6 B7 B8 B9 B10 T2 B11 B12 B13 B14 B15
     */


    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string dest = Console.ReadLine();

            List<string> stationsA = new List<string>() 
            {
                "A1", "A2", "A3",  "A4", "A5", "A6", "A7", "A8", "A9", "T1", "A10", "A11", "A12", "A13", "T2", "A14", "A15", "A16", "A17", "A18"
            };

            List<string> stationsB = new List<string>() 
            {
                "B1", "B2", "B3", "B4", "B5", "T1", "B6", "B7", "B8", "B9", "B10", "B100","B101","T2", "B11", "B12", "B13", "B14", "B15"
            };

            List<string> allStations = new List<string>();
            foreach (string a in stationsA)
            {
                if (!allStations.Contains(a))
                    allStations.Add(a);
            }
            foreach (string b in stationsB)
            {
                if (!allStations.Contains(b))
                    allStations.Add(b);
            }
            Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
            for (int i = 0; i < stationsA.Count;i++)
            {
                string source = stationsA[i];
                if (!map.ContainsKey(source))
                    map.Add(source, new List<string>());
                if (i - 1 >= 0)
                    map[source].Add(stationsA[i - 1]);
                if (i + 1 < stationsA.Count)
                    map[source].Add(stationsA[i + 1]);
            }
            for (int i = 0; i < stationsB.Count; i++)
            {
                string source = stationsB[i];
                if (!map.ContainsKey(source))
                    map.Add(source, new List<string>());
                if (i - 1 >= 0)
                    map[source].Add(stationsB[i - 1]);
                if (i + 1 < stationsB.Count)
                    map[source].Add(stationsB[i + 1]);
            }
            getMin(new List<string>() { start }, map, dest);
            foreach (string str in Min)
            {
                if (Min.IndexOf(str) != 0)
                    Console.Write(" ");
                Console.Write(str);
            }
            Console.ReadLine();

            


        }

        static List<string> Min;

        static void getMin(List<string> passStations, Dictionary<string, List<string>> map,string dest)
        {
            string last = passStations[passStations.Count - 1];
            if (last == dest)
            {
                if (Min == null || passStations.Count < Min.Count)
                {
                    Min = passStations;
                }
            }
            foreach (string sub in map[last])
            {
                if (!passStations.Contains(sub))
                {
                    List<string> newPassStations = new List<string>(passStations);
                    newPassStations.Add(sub);
                    getMin(newPassStations, map, dest);
                }
            }
        }





    }
}
