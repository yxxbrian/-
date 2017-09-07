using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = escapeString("vec: \"D: \\Library\\RfDesign\\GD_32\\myVec.vec\"");
        }

        static string escapeString(string s)
        {
            List<char> splitchar = new List<char> { };
            foreach (char c in s)
            {
                /*
                if (c == '\"')
                {
                    splitchar.Add('\\');
                    splitchar.Add('\"');

                }*/
                //else 
                if (c == '\\')
                {
                    splitchar.Add('\\');
                    splitchar.Add('\\');

                }
                else
                {
                    splitchar.Add(c);
                }
            }
            string ss = null;
            StringBuilder sb = new StringBuilder();
            foreach (char c in splitchar)
            {
                sb.Append(c.ToString());
            }
            ss = sb.ToString();
            return ss;
        }
    }
}
