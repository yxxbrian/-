using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单错误记录
{
    class ERROR 
    {
        public ERROR(string file,string line,int count) 
        {
            this.file = file;
            this.line = line;
            this.count = count;
        }

        public string file;
        public string line;
        public int count;
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<ERROR> ErrorQueue = new List<ERROR>();


            string inputline;
            while (!string.IsNullOrEmpty(inputline = Console.ReadLine())) 
            {
                string[] lineSplits = inputline.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string file = lineSplits[0].Substring(lineSplits[0].LastIndexOf('\\')+1);
                if(file.Length>16)
                {
                    file = file.Substring(file.Length-16);
                }
                string line = lineSplits[1];
                bool find = false;
                foreach (ERROR error in ErrorQueue)
                {
                    if (error.file == file && error.line == line)
                    {
                        error.count += 1;
                        find = true;
                    }
                }
                if (find == false)
                {
                    ERROR e = new ERROR(file, line, 1);
                    ErrorQueue.Add(e);
                }
                //if (ErrorQueue.Count > 8)
                //{
                //    ErrorQueue.Dequeue();
                //}
            }
            int start = 0;
            if (ErrorQueue.Count > 8)
                start = ErrorQueue.Count - 8;
            
            for (int i = start; i < ErrorQueue.Count; i++)
            {
                ERROR e = ErrorQueue[i];
                Console.WriteLine(e.file + " " + e.line + " " + e.count);
            }
            
            //Console.ReadLine();

        }
    }
}
