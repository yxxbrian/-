using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 输入一个链表，反转链表后，输出链表的所有元素。
 */
namespace 反转链表
{
    class Program
    {
        static void Main(string[] args)
        {
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
            public ListNode ReverseList(ListNode pHead)
            {
                // write code here
                ListNode dst = null;
                while (pHead != null) 
                {
                    ListNode cur = pHead;
                    pHead = pHead.next;
                    cur.next = dst;
                    dst = cur;
                }
                return dst;
            }
        }


    }
}
