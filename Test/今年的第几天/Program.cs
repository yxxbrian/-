using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 今年的第几天
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string str = "";
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                string[] splits = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int year = int.Parse(splits[0]);
                int month = int.Parse(splits[1]);
                int day = int.Parse(splits[2]);

                bool isRunNian = (year % 4 == 0);
                int count = 0;
                for (int i = 0; i < month-1; i++)
                    count += days[i];
                count += day;
                if (month > 2 && isRunNian)
                    count += 1;
                Console.WriteLine(count);
            }

        }




    }
}
