using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Hashtable_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate_unnamedDelegate_Lamada();

            Console.ReadLine();
        }

        class Person 
        {
            public void HowToDo(DoSomething del, int num) 
            {
                del(num);
            }
        }

        delegate void DoSomething(int a);

        public static void Write(int a)
        {
            Console.WriteLine(a);
        }

        static void Delegate_unnamedDelegate_Lamada() 
        {
            //Delegate
            Person p = new Person();
            p.HowToDo(new DoSomething(Write), 10);

            //unamed delegate
            p.HowToDo(new DoSomething(delegate(int a) 
                {
                    Console.WriteLine(a + a);
                }), 10);

            //lamda
            p.HowToDo((int a) => 
            {
                Console.WriteLine(a * 3);
            }, 10);

            //


        }


        static void HashTableTest() 
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Nanjing", 1985);
            hashtable.Add("Qingtao", 1992);
            hashtable.Add("Beijing", 1949);
            hashtable.Add("Suzhou", null);
            bool contains = hashtable.ContainsKey("Suzhou");
            bool age = (bool)hashtable["Suzhou"];

            HashSet<int> hashset = new HashSet<int>();
            bool res = false;
            res = hashset.Add(2012);
            res = hashset.Add(2016);
            res = hashset.Add(2016);
            // int a = hashset[0];

        }


    }
}
