using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int sum = int.Parse(inputStr);
            string elementsStr = Console.ReadLine();
            string[] elementsStrSplits = elementsStr.Split(new char[]{' '});
            List<int> elementsIntList = new List<int>();
            foreach (string ele in elementsStrSplits)
            {
                elementsIntList.Add(int.Parse(ele));
            }
            
            //sum elementsIntList
            List<int> resultInts = new List<int>();
            bool result = canGetSum(sum, elementsIntList,resultInts);
            List<int> indexList = new List<int>();


            for (int i = 0; i < resultInts.Count;i++ )
            {
                indexList.Add(elementsIntList.IndexOf(resultInts[i]));
            }
            for (int i = 0; i < elementsIntList.Count; i++)
            {
                if (i != 0)
                    Console.Write(" ");
                if (indexList.Contains(i))
                    Console.Write(1);
                else
                    Console.Write(0);
            }
            Console.ReadKey();
        }
        

        private static bool canGetSum(int sum, List<int> intList,List<int> resultInts)
        {
            //
            foreach (int i in intList)
            {
                if (i == sum)
                {
                    resultInts.Add(i);
                    return true;
                }
            }
            if (intList.Count <= 1)
                return false;
            bool result = false;
            for(int i=0;i<intList.Count;i++)
            {
                List<int> newList = new List<int>(intList);
                newList.RemoveAt(i);
                if (canGetSum(sum - intList[i], newList, resultInts))
                {
                    result = true;
                    resultInts.Add(intList[i]);
                    break;

                }
            }
            return result;

        }


    }
}
