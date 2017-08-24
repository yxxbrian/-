using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 输入一个链表，输出该链表中倒数第k个结点
 */
namespace 链表中倒数第K个节点
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            ListNode node = sol.produceListNode(new int[]{1,2,3,4,5});
            ListNode res = sol.FindKthToTail(node, 1);
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


        //21 ms	2592K
        class Solution
        {
            public ListNode FindKthToTail(ListNode head, int k)
            {
                // write code here
                if (head == null)
                    return null;
                int distance = k-1;
                ListNode prehead = head;
                ListNode lateDst = null;
                while (prehead.next != null)
                {
                    prehead = prehead.next;
                    if (lateDst != null)
                        lateDst = lateDst.next;
                    else
                    {
                        if (--distance == 0)
                            lateDst = head;
                    }
                }
                if (k == 1)
                    return prehead;
                else
                    return lateDst;
            }


            public ListNode produceListNode(int[] array)
            {
                ListNode exist = null;
                for (int i = array.Length-1; i >= 0; i--)
                {
                    ListNode node = new ListNode(array[i]);
                    node.next = exist;
                    exist = node;
                }
                return exist;
            }

        }


    }
}
