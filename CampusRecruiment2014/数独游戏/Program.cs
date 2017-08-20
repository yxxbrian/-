using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 数独游戏
{
    class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = File.OpenText("C:\\Users\\Brian_PC\\Desktop\\New2.txt");
            
            int[][] map = new int[9][];
            for (int i = 0; i < 9; i++)
                map[i] = new int[9];
            int lineIndex = 0;
            List<Point> emptyPoints = new List<Point>();
            while (lineIndex<9)
            {
                //string inputStr = Console.ReadLine();
                string inputStr = s.ReadLine();
                string[] inputStrSplits = inputStr.Split(new char[] { ' ' });

                int id = 0;
                foreach (string str in inputStrSplits)
                {
                    int val = int.Parse(str);
                    map[lineIndex][id] = val;
                    if (val == 0)
                    {
                        emptyPoints.Add(new Point(lineIndex,id));
                    }
                    id++;
                }
                lineIndex++;
            }
            int[][] resMap = getEmptyResults(map, new List<int>(), emptyPoints);
            if (resMap != null)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j != 0)
                            Console.Write(" ");
                        Console.Write(resMap[i][j]);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("No answer");
            Console.ReadLine();
        }

        static int[][] getMapCopy(int[][] map)
        {
            int[][] newMap = new int[map.Length][];
            for (int i = 0; i < map.Length; i++)
                newMap[i] = new int[map[i].Length];
            for (int i = 0; i < newMap.Length; i++)
                for (int j = 0; j < newMap[0].Length; j++)
                    newMap[i][j] = map[i][j];
            return newMap;
        }

        static int[][] getEmptyResults(int[][] map, List<int> curEmptyResults, List<Point> leftEmptyPoints) 
        {
            if (leftEmptyPoints.Count == 0)
                return map;
            else 
            {
                Point curPoint = leftEmptyPoints[0];
                List<int> candidateNumbers = getPointResultCandidate(map, curPoint);
                if (candidateNumbers.Count == 0)
                    return null;
                else 
                {
                    foreach (int cand in candidateNumbers) 
                    {
                        int[][] newMap = getMapCopy(map);//.ToArray());
                        List<int> newCurEmptyResults = new List<int>(curEmptyResults.ToArray());
                        List<Point> newLeftEmptyPoints = new List<Point>(leftEmptyPoints.ToArray());
                        newMap[curPoint.X][curPoint.Y] = cand;
                        newCurEmptyResults.Add(cand);
                        newLeftEmptyPoints.RemoveAt(0);
                        int[][] resMap = getEmptyResults(newMap, newCurEmptyResults, newLeftEmptyPoints);
                        if (resMap != null)
                            return resMap;
                    }
                    return null;
                }
            }
        }


        static List<int> getPointResultCandidate(int[][] map, Point point) 
        {
            List<int> usedNumbers = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (!usedNumbers.Contains(map[point.X][i]))
                    usedNumbers.Add(map[point.X][i]);
                if (!usedNumbers.Contains(map[i][point.Y]))
                    usedNumbers.Add(map[i][point.Y]);
            }
            List<int> candidateNumber = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                if (!usedNumbers.Contains(i))
                    candidateNumber.Add(i);
            }
            return candidateNumber;
        }


    }
}
