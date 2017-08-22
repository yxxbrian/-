using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 用两个栈来实现一个队列，完成队列的Push和Pop操作。 队列中的元素为int类型。
 
 */

//运行时间：34ms
//占用内存：2916k
namespace 用栈实现队列
{

    class Solution
    {
        System.Collections.Generic.Stack<int> firstStack = new Stack<int>();
        Stack<int> secondStack = new Stack<int>();
        public void push(int node)
        {
            firstStack.Push(node);
        }
        public int pop()
        {
            while (firstStack.Count > 0)
                secondStack.Push(firstStack.Pop());
            int res = secondStack.Pop();
            while (secondStack.Count > 0) 
            {
                firstStack.Push(secondStack.Pop());
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
