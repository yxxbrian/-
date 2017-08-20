using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 从尾到头打印链表
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }
        static void Main(string[] args)
        {

        }

        public List<int> printListFromTailToHead(ListNode listNode)
        {
            List<int> res = new List<int>();
            // write code here
            while (listNode != null)
            {
                res.Add(listNode.val);
                listNode = listNode.next;
            }
            List<int> lastRes = new List<int>();
            for (int a = res.Count - 1; a >= 0; a--)
                lastRes.Add(res[a]);
            return lastRes;
        }
    }
}
