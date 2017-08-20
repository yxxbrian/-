using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JianzhiOffer_0
{
    //类型的静态变量初始化只会执行一次，期间线程互斥，安全
    //但是_instance会在第一次访问的时候就实例化，但是不一定会使用到，降低了效率
    class Singleton_3
    {
        private Singleton_3()
        {
            //
        }
        private static Singleton_3 _instance = new Singleton_3();

        public Singleton_3 Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
