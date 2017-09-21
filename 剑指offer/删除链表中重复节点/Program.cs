using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 在一个排序的链表中，存在重复的结点，请删除该链表中重复的结点，重复的结点不保留，返回链表头指针。 
 * 例如，链表1->2->3->3->4->4->5 处理后为 1->2->5
 */
namespace 删除链表中重复节点
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
            public ListNode deleteDuplication(ListNode pHead)
            {
                // write code here
                if (pHead == null)
                    return null;
                ListNode hd = null;
                ListNode cur = pHead;
                while (cur != null)
                {
                    
                }
                return pHead;
            }
        }

    }
}
