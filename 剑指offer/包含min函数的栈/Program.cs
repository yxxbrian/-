using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 包含min函数的栈
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        class Solution
        {
            Stack<int> dataStack = new Stack<int>();
            Stack<int> minStack = new Stack<int>();
            public void push(int node)
            {
                dataStack.Push(node);
                if (minStack.Peek() == null || minStack.Peek() > node)
                    minStack.Push(node);
            }
            public void pop()
            {
                dataStack.Pop();
                if (dataStack.Peek() == minStack.Peek())
                    minStack.Pop();
            }
            public int top()
            {
                return dataStack.Peek();

            }
            public int min()
            {
                return minStack.Peek();
            }
        }




    }
}
