using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace RecordMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int num = 0;
            Dictionary<int, int> result = new Dictionary<int, int>();
            List<string> inputArr = new List<string>();
            while ((line = System.Console.ReadLine()) != null)
            {
                inputArr.Add(line.Trim());
                num = int.Parse(inputArr[0]);
                if (inputArr.Count == num + 1)
                {
                    for (int i = 1; i < num+1; i++)
                    {  
                        string[] arr = inputArr[i].Split(' ');
                        int index = int.Parse(arr[0]);
                        int value = int.Parse(arr[1]);
                        if (result.ContainsKey(index))
                        {
                            result[index] += value;
                        }
                        else
                        {
                            result.Add(index, value);
                        }
                    }
                    Dictionary<int,int> consoleRep = (from d in result
                                                      orderby d.Key ascending
                                                  select d).ToDictionary(k => k.Key, v => v.Value);
 
                    foreach (var dic in consoleRep)
                    {
                        System.Console.WriteLine(dic.Key + " " + dic.Value);
                    }
                }
            }
        }
    }
}