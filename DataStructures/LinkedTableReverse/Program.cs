using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedTableReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedListFactory fac = new LinkedListFactory();
            LinkedList list = fac.produceLinkedList();
            PrintLinkedList(list);
            Console.ReadLine();
        }

        static void PrintLinkedList(LinkedList list) 
        {
            LinkedList tmp = list;
            while (tmp != null)
            {
                Console.WriteLine(tmp.ToString());
                tmp = tmp.next;
            }
        }

    }
}
