using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 输入n个整数，找出其中最小的K个数。
 * 例如输入4,5,1,6,2,7,3,8这8个数字，
 * 则最小的4个数字是1,2,3,4,。
 */
namespace 最小的K个数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 5, 1, 6, 2, 7, 3, 8 };
            List<int> res = new Solution().GetLeastNumbers_Solution(input, 4);
        }


        class Solution
        {
            public List<int> GetLeastNumbers_Solution(int[] input, int k)
            {
                // write code here
                if (k > input.Length || k==0)
                    return new List<int>();

                List<int> tmpResult = new List<int>();
                foreach (int i in input)
                {
                    if ((tmpResult.Count == k && i < tmpResult[k - 1]) || tmpResult.Count < k)
                    {
                        Push(tmpResult, i,k);
                    }
                }
                return tmpResult;
            }

            private void Push(List<int> tmpList, int i,int totalLength)
            {
                if (tmpList.Count == totalLength)
                {
                    tmpList.RemoveAt(tmpList.Count - 1);
                }
                tmpList.Add(i);
                Sort(tmpList, 0, tmpList.Count - 1);

            }

            private void Sort(List<int> tmpList, int start, int end)
            {
                if (end - start <= 1)
                {
                    if (end == start + 1)
                        if (tmpList[start] > tmpList[end])
                            Exchange(tmpList, start, end);
                }
                else
                {
                    int standard = tmpList[start];
                    int st = start+1;
                    int ed = end;
                    while (st < ed)
                    {
                        while (tmpList[ed] > standard && ed>=st)
                            ed--;
                        while (tmpList[st] < standard)
                            st++;
                        if (st < ed)
                        {
                            Exchange(tmpList, ed, st);
                        }
                        else
                            break;
                    }
                    Exchange(tmpList, start, ed);
                    Sort(tmpList, start, ed - 1);
                    Sort(tmpList, ed + 1, end);
                }
            }

            private void Exchange(List<int> list,int i,int j)
            {
                int tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }

        }

    }
}
