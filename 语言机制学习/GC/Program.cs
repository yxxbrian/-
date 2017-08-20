using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Network net = new Network();
            net.Dispose(true);
            Console.ReadLine();
        }
    }
}
