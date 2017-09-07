using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 一个整型数组里除了两个数字之外，其他的数字都出现了两次。请写程序找出这两个只出现一次的数字。 
 * 
 */
namespace 数组中只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //num1,num2分别为长度为1的数组。传出参数
    //将num1[0],num2[0]设置为返回结果
    class Solution
    {
        public void FindNumsAppearOnce(int[] array, int[] num1, int[] num2)
        {
            // write code here
            
            Dictionary<int,int> countDic = new Dictionary<int,int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!countDic.ContainsKey(array[i]))
                    countDic.Add(array[i], 1);
                else
                    countDic[array[i]]++;
            }
            int index = 0;
            foreach (KeyValuePair<int, int> p in countDic)
            {
                if (p.Value == 1)
                {
                    if (index == 0)
                    {
                        num1[0] = p.Key;
                        index++;
                        continue;
                    }
                    else 
                    {
                        num2[0] = p.Key;
                    }
                }
            }
        }
    }

}
