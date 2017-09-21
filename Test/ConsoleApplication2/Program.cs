using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 题目描述：
用户的密码分为4个等级，具体定义如下：
等级0：密码小于8位/密码与用户名一样或相反/只包含4类字符中的任意一类
等级1：大于等于8位包含两类字符，且组合为(数字+小写字母)或(数字+大写字母)
等级2：大于等于8位包含两类字符，且组合不能为(数字+小写字母)和(数字+大写字母)
等级3：大于等于8位包含三类以上字符
其中4类字符为：数字，小写字母，大写字母，特殊字符(除了数字，小写字母，大写字母外的字符)
 */
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splits = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = splits[0];
            string password = splits[1];

            

            //数字、小写、大写、其他
            int[] countArray = new int[4] { 0, 0, 0, 0 };
            int rank = -1;

            if (password.Length == 0)
                rank = 0;
            
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                    countArray[0] = 1;
                else if (c >= 'a' && c <= 'z')
                    countArray[1] = 1;
                else if (c >= 'A' && c <= 'Z')
                    countArray[2] = 1;
                else
                    countArray[3] = 1;
            }
            int sum = 0;
            foreach (int i in countArray)
                sum += i;
               
            //Rank 0
            if (name.Equals(password))
            {
                rank = 0;
            }
            else if (password.Length < 8) 
            {
                rank = 0;
            }
            else if (password.Length == name.Length)
            {
                bool same = true;
                for (int i = 0; i < password.Length; i++)
                    if (password[i] != name[name.Length - 1 - i])
                        same = false;
                if (same)
                    rank = 0;
            }

            //Rank 1
            if (rank == -1) 
            {
                if (password.Length > 8 &&
                    (countArray[0] == 1 && countArray[1] == 1 && countArray[2] == 0 && countArray[3] == 0) ||
                    (countArray[0] == 1 && countArray[1] == 0 && countArray[2] == 1 && countArray[3] == 0)
                    )
                    rank = 1;
            }
            //Rank 2
            if (rank == -1)
            {
                if (sum == 2)
                    rank = 2;
            }

            //Rank 3
            if (rank == -1)
            {
                if (sum >= 3)
                    rank = 3;
            }
            Console.WriteLine(rank);
            Console.ReadLine();
        }
    }
}
