using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] firstsplits = input.Split(new char[] { ' ' });

            if (firstsplits.Length == 1 || string.IsNullOrWhiteSpace(firstsplits[1]))
                Console.WriteLine(firstsplits[0]);
            string[] secondsplits = firstsplits[0].Split(new string[] { firstsplits[1] },StringSplitOptions.None);
           // string[] secondsplits = firstsplits[0].Split(new char[]{firstsplits[1][0]});
            for (int i = 0; i < secondsplits.Length; i++)
                if(!string.IsNullOrEmpty(secondsplits[i]) || i != secondsplits.Length)
                Console.WriteLine(secondsplits[i]);
            


        }
    }
}
