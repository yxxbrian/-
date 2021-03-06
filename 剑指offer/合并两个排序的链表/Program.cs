﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 输入两个单调递增的链表，输出两个链表合成后的链表，当然我们需要合成后的链表满足单调不减规则。
 */

namespace 合并两个排序的链表
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
        class Solution1
        {
            public ListNode Merge(ListNode pHead1, ListNode pHead2)
            {
                // write code here
                if (pHead1 == null)
                    return pHead2;
                else if (pHead2 == null)
                    return pHead1;
                else
                {
                    if (pHead1.val < pHead2.val)
                    {
                        pHead1.next = Merge(pHead1.next, pHead2);
                        return pHead1;
                    }
                    else
                    {
                        pHead2.next = Merge(pHead1, pHead2.next);
                        return pHead2;
                    }
                }
            }
        }


        //24 ms	2536K
        class Solution
        {
            public ListNode Merge(ListNode pHead1, ListNode pHead2)
            {
                // write code here
                ListNode dst = null;
                if (pHead1 == null)
                    return pHead2;
                else if (pHead2 == null)
                    return pHead1;
                else 
                {
                    //Initialize
                    ListNode cur1 = pHead1;
                    ListNode cur2 = pHead2;
                    ListNode curDst = dst;
                    if (cur1.val < cur2.val)
                    {
                        curDst = cur1;
                        cur1 = cur1.next;
                    }
                    else
                    {
                        curDst = cur2;
                        cur2 = cur2.next;
                    }
                    dst = curDst;


                    while (cur1 != null && cur2 != null)
                    {
                        if (cur1.val < cur2.val)
                        {
                            curDst.next = cur1;
                            curDst = curDst.next;
                            cur1 = cur1.next;
                        }
                        else
                        {
                            curDst.next = cur2;
                            curDst = curDst.next;
                            cur2 = cur2.next;
                        }
                    }
                    if (cur1 != null)
                        curDst.next = cur1;
                    else
                        curDst.next = cur2;
                    return dst;


                }
            }
        }




    }
}
