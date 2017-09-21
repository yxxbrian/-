using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 链表中环的入口节点
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node_1 = new ListNode(1);
            ListNode node_2 = new ListNode(2);
            ListNode node_3 = new ListNode(3);
            ListNode node_4 = new ListNode(4);
            ListNode node_5 = new ListNode(5);
            node_1.next = node_2;
            node_2.next = node_3;
            node_3.next = node_4;
            node_4.next = node_5;
            node_5.next = node_3;
            Solution1 sol = new Solution1();
            ListNode res = sol.EntryNodeOfLoop(node_1);


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

    class Solution1
    {
        public ListNode EntryNodeOfLoop(ListNode pHead) 
        {
            if (pHead == null || pHead.next == null)
                return null;
            ListNode forward = pHead,backward = pHead;
            while (true)
            {
                if ((forward != null && forward.next != null && forward.next.next != null) && (backward != null && backward.next != null))
                {
                    forward = forward.next.next;
                    backward = backward.next;
                    if (forward == backward)
                        break;
                }
                else
                {
                    return null;
                }
            }
            if (forward == backward)
            {
                forward = pHead;
                while (forward != backward)
                {
                    forward = forward.next;
                    backward = backward.next;
                }
                if (forward == backward)
                    return backward;
            }
            return null;
        }
    
    }


    class Solution
    {
        public ListNode EntryNodeOfLoop(ListNode pHead)
        {
            // write code here
            List<ListNode> nodes = new List<ListNode>();
            while (pHead != null)
            {
                if (nodes.Contains(pHead))
                {
                    return pHead;
                }
                else
                {
                    nodes.Add(pHead);
                    pHead = pHead.next;
                }
            }
            return null;
        }
    }


}
