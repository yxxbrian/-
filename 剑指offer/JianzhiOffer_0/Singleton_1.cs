using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JianzhiOffer_0
{
    //线程安全，但是每次访问都要用到同步所，效率太低
    class Singleton_1
    {
        private Singleton_1()
        {
            //
        }
        private static object SynObject = new object();
        private static Singleton_1 _instance = null;

        public Singleton_1 Instance
        {
            get
            {
                lock (SynObject)
                {
                    if (_instance == null)
                        _instance = new Singleton_1();
                    return _instance;
                }
            }
        }
    }
}
