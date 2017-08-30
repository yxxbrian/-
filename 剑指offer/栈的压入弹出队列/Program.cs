using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈的压入弹出队列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pushV = new int[] { 1, 2, 3, 4, 5 };
            int[] popV = new int[] { 4, 5, 3, 2, 1 };
            bool res = new Solution().IsPopOrder(pushV, popV);
        }
        class Solution
        {
            public bool IsPopOrder(int[] pushV, int[] popV)
            {
                // write code here
                int pushIndex = 0;
                int popIndex = 0;
                Stack<int> stack = new Stack<int>();
                while (pushIndex < pushV.Length)
                {
                    stack.Push(pushV[pushIndex]);
                    while (stack.Count > 0 && stack.Peek() == popV[popIndex])
                    {
                        stack.Pop();
                        popIndex++;
                    }
                    pushIndex++;
                }
                if (popIndex == popV.Length)
                    return true;
                return false;
            }
        }


    }
}
