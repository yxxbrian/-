using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 输入两个链表，找出它们的第一个公共结点。
 */
namespace 两个链表的第一个公共节点
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
    class Solution
    {
        public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            List<ListNode> passValues = new List<ListNode>();
            while (true)
            {
                if (pHead1 != null)
                {
                    if (passValues.Contains(pHead1))
                        return pHead1;
                    else
                    {
                        passValues.Add(pHead1);
                        pHead1 = pHead1.next;
                    }
                }
                if (pHead2 != null)
                {
                    if (passValues.Contains(pHead2))
                        return pHead2;
                    else
                    {
                        passValues.Add(pHead2);
                        pHead2 = pHead2.next;
                    }
                }
                if (pHead1 == null && pHead2 == null)
                    return null;
            }
        }
    }

}
