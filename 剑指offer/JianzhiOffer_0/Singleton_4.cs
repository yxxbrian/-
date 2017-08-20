using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JianzhiOffer_0
{
    //最好，线程安全，且只在访问Instance 的时候才进行实例化
    class Singleton_4
    {
        private Singleton_4()
        {
            //
        }
        class Nested
        {
            public Nested() 
            {
                //
            }
            public static Singleton_4 _instance = new Singleton_4();
        }
        public Singleton_4 Instance
        {
            get
            {
                return Nested._instance;
            }
        }
    }
}
