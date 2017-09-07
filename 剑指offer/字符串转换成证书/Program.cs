using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串转换成整数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Solution
    {
        public int StrToInt(string str)
        {
            // write code here
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            int result = 0;
            int wei = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (i == 0 && (str[i] == '+' || str[i] == '-'))
                {
                    if (str[i] == '+')
                        return result;
                    else if (str[i] == '-')
                        return -1 * result;
                }
                if (str[i] < '0' || str[i] > '9')
                    return 0;
                int cur = str[i] - '0';
                result += cur * (int)Math.Pow(10, wei);
                wei++;
            }
            return result;
        }
    }

}
