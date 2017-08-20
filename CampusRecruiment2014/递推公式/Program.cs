using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 递推公式
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = getNext(num);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static string getNext(int n)
        {
            if(n==1)
                return "2";
            else
            {
                string lowerResult = getNext(n - 1);
                string a = add(lowerResult, lowerResult);
                string b = add(a, "2");
                return b;
            }
        }


        static string add(string str1, string str2)
        {
            int length = str1.Length;
            str2 = str2.PadLeft(length,'0');
            List<int> results = new List<int>();
            int jinwei = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                int s = str1[i] - '0' + str2[i] - '0'+jinwei;
                results.Insert(0, s % 10);
                jinwei = s / 10;
            }
            if (jinwei > 0)
                results.Insert(0, jinwei);
            string sb = "";
            foreach (int i in results)
                sb+=(i);
            return sb.ToString();
        }


    }
}
