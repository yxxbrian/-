using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JianzhiOffer_0
{
    //改进版，仅在实例化instance对象的时候上锁
    //但是依然需要通过锁来实现线程安全
    class Singleton_2
    {
        private Singleton_2()
        {
            //
        }
        private static object SynObject = new object();
        private static Singleton_2 _instance = null;

        public Singleton_2 Instance
        {
            get
            {

                if (_instance == null)
                {
                    lock (SynObject)
                    {
                        _instance = new Singleton_2();
                    }
                }
                return _instance;
            }
        }
    }
}
