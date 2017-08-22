using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedTableReverse
{
    class LinkedListFactory:ILinkedListFactory
    {
        public LinkedList produceLinkedList() 
        {
            LinkedList list = null;
            LinkedList cur = null;
            for (int i = 0; i < 10; i++)
            {
                LinkedList next = new LinkedList();
                next.data = "linkedList" + i;
                if (list == null)
                {
                    list = next;
                    cur = next;
                }
                else
                {
                    cur.next = next;
                    cur = next;
                }
            }
            return list;
        }

    }
}
