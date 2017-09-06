using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
/*
 * 输入一个正整数数组，把数组里所有数字拼接起来排成一个数，
 * 打印能拼接出的所有数字中最小的一个。
 * 例如输入数组{3，32，321}，则打印出这三个数字能排成的最小数字为321323。
 */
namespace 把数组排成最小的数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string s= sol.PrintMinNumber(new int[] { 3,5,1,4,2});
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
        }
    }

    class Solution
    {
        
        public string PrintMinNumber(int[] numbers)
        {
            // write code here
            List<int> tmpResult = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (tmpResult.Count > 0)
                {
                    bool inserted = false;
                    for (int j = 0; j < tmpResult.Count; j++)
                    {
                        int comp = CompareTwo(numbers[i], tmpResult[j]);
                        if (comp == -1)
                        {
                            tmpResult.Insert(j, numbers[i]);
                            inserted = true;
                            break;
                        }
                    }
                    if (inserted == false)
                        tmpResult.Add(numbers[i]);
                }
                if (tmpResult.Count == 0) 
                {
                    tmpResult.Add(numbers[i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (int i in tmpResult)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }

        public int CompareTwo(int A, int B)
        {
            List<int> ASplits = getSplits(A);
            List<int> BSplits = getSplits(B);
            int minLen = ASplits.Count < BSplits.Count ? ASplits.Count : BSplits.Count;
            for(int i=0;i<minLen;i++)
            {
                if (ASplits[i] < BSplits[i])
                    return -1;
                else if (ASplits[i] > BSplits[i])
                    return 1;
            }
            int baseIndex = minLen;
            if (ASplits.Count > BSplits.Count)
            {
                int rest = ASplits.Count - minLen;
                for (int i = 0; i < rest; i++)
                {
                    if (ASplits[baseIndex + i] < ASplits[i])
                        return -1;
                    else if (ASplits[baseIndex + i] > ASplits[i])
                        return 1;
                }
            }
            else if (ASplits.Count < BSplits.Count)
            {
                int rest = BSplits.Count - minLen;
                for (int i = 0; i < rest; i++)
                {
                    if (BSplits[i] < BSplits[baseIndex + i] )
                        return -1;
                    else if (BSplits[i] > BSplits[baseIndex + i] )
                        return 1;
                }
            }
            return 0;

        }

        private List<int> getSplits(int n)
        {
            List<int> splits = new List<int>();
            while (n != 0)
            {
                splits.Insert(0, n % 10);
                n /= 10;
            }
            return splits;
        }
    }

}
