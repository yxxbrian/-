using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串空格替换
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string replaceSpace(string str) 
        {
            return str.Replace(" ", "%20");
        }



        //24 ms	2788K
        public string replaceSpace1(string str)
        {
            // write code here
            int length = str.Length;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(str.Length * 2);
            foreach (char c in str)
            {
                if (c == ' ')
                    sb.Append("%20");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

    }
}
