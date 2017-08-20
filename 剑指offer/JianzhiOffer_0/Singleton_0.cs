using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JianzhiOffer_0
{
    //Singleton 0
    //适合单线程，线程不安全
    class Singleton_0
    {
        private Singleton_0() 
        {
            //
        }

        private static Singleton_0 _instance = null;

        public Singleton_0 Instance 
        {
            get 
            {
                if (_instance == null)
                    _instance = new Singleton_0();
                return _instance;
            }
        }
    }
}
