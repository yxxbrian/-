using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GC
{
    class Network:IDisposable
    {
        public Network() 
        {
            info = "Network"+index++;
            pt = new FileStream(@"C:\Users\Brian_PC\Desktop\geek.json", FileMode.OpenOrCreate);
            pt.Write(new byte[] { 0x00, 0x01, 0x11, 0x12 }, 0, 4);
        }
        static int index = 0;
        string info;
        FileStream pt;

        ~Network() 
        {
            Dispose(false);
        }

        bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Going to dispose:" + disposing);
            if (disposed == false)
            {
                //Managed
                if(disposing == true)
                {
                    info = null;
                }
                //unmanaged
                pt.Close();
                disposed = true;
            }
        }
        public void Dispose() 
        {
            Dispose(true);
        }


    }
}
