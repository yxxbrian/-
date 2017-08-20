using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusRecruiment2014_1
{
    /*
     初级题：从考试成绩中划出及格线 
    10个学生考完期末考试评卷完成后，A老师需要划出及格线，要求如下：
    (1) 及格线是10的倍数；
    (2) 保证至少有60%的学生及格；
    (3) 如果所有的学生都高于60分，则及格线为60分
     */



    class Program
    {
        

        static void Main(string[] args)
        {
            double[] scores = new double[10];
            for (int i = 0; i < scores.Length; i++)
            {
                double tempScore = Convert.ToDouble(Console.ReadLine());
                scores[i] = tempScore;
            }

            int line=0;
            for (int j=0; j <= 100; j+=10)
            {
                int biggerCount = getBiggerCount(scores, j);
                if (biggerCount >= 6)
                    line = j;
            }
            if (line > 60)
                line = 60;

            Console.WriteLine(line);
            Console.ReadKey();
        }

        static int getBiggerCount(double[] scores, int lineScore)
        {
            int count = 0;
            foreach (double score in scores)
            {
                if (score > lineScore)
                    count++;
            }
            return count;
        }

    }
}
