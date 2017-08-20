using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campus_2018_3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
            int diaoyongNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < diaoyongNum; i++)
            {
                string input = Console.ReadLine();
                string[] inputSplits = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in inputSplits)
                {
                    if (!map.ContainsKey(str))
                        map.Add(str, new List<string>());
                }
                map[inputSplits[0]].Add(inputSplits[1]);
            }
            //jianyan
            string inputCheck = Console.ReadLine();
            string[] inputSplitsCheck = inputCheck.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string A = inputSplitsCheck[0];
            string B = inputSplitsCheck[1];

            List<string> A_DiaoyongLiebiao = new List<string>();
            getDiaoyongHanshu(map, A, A_DiaoyongLiebiao);
            List<string> B_DiaoyongLiebiao = new List<string>();
            getDiaoyongHanshu(map, B, B_DiaoyongLiebiao);
            if (A_DiaoyongLiebiao.Contains(B) && B_DiaoyongLiebiao.Contains(A))
                Console.WriteLine("T");
            else
                Console.WriteLine("F");
            Console.ReadLine();
        }

        static void getDiaoyongHanshu(Dictionary<string, List<string>> map, string origin, List<string> DiaoyongLiebiao)
        {
            if (map.ContainsKey(origin))
            {
                foreach (string obj in map[origin])
                {
                    if (!DiaoyongLiebiao.Contains(obj))
                    {
                        DiaoyongLiebiao.Add(obj);
                        getDiaoyongHanshu(map, obj, DiaoyongLiebiao);
                    }
                }
            }
        }
    }
}
