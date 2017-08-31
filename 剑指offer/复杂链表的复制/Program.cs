using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 输入一个复杂链表（每个节点中有节点值，以及两个指针，一个指向下一个节点，
 * 另一个特殊指针指向任意一个节点），返回结果为复制后复杂链表的head。
 * （注意，输出结果中请不要返回参数中的节点引用，否则判题程序会直接返回空）
 */

namespace 复杂链表的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomListNode n1 = new RandomListNode(1);
            RandomListNode n2 = new RandomListNode(2);
            RandomListNode n3 = new RandomListNode(3);
            RandomListNode n4 = new RandomListNode(4);
            RandomListNode n5 = new RandomListNode(5);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            
            n1.random = n3;
            n2.random = n5; 
            n3.random = null;
            n4.random = n2;
            n5.random = null;

            RandomListNode result = new Solution().Clone(n1);
        }

        public class RandomListNode
        {
            public int label;
            public RandomListNode next, random;
            public RandomListNode(int x)
            {
                this.label = x;
            }
        }
        class Solution
        {
            public RandomListNode Clone(RandomListNode pHead)
            {
                // write code here
                if (pHead == null)
                    return null;
                RandomListNode curNode = pHead;
                RandomListNode next = curNode.next;
                while (curNode != null)
                {
                    RandomListNode added = new RandomListNode(curNode.label);
                    curNode.next = added;
                    added.next = next;
                    if (next != null)
                    {
                        curNode = next;
                        next = curNode.next;
                    }
                    else
                        break;
                }
                //Fix random pointer
                curNode = pHead;
                while (curNode != null)
                {
                    next = curNode.next;
                    if (curNode.random != null)
                    {
                        next.random = curNode.random.next;
                    }
                    curNode = next.next;
                }
                //Seperate
                RandomListNode result = pHead.next;
                RandomListNode cur = result;
                while (cur != null)
                {
                    if (cur.next != null)
                    {
                        cur.next = cur.next.next;
                        cur = cur.next;
                    }
                    else
                    {
                        cur.next = null;
                        break;
                    }
                }
                pHead.next = null;
                return result;
            }
        }


    }
}
