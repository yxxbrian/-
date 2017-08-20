using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 时间限制：1秒
空间限制：32768K
在一个N*N的数组中寻找所有横，竖，左上到右下，右上到左下，四种方向的直线连续D个数字的和里面最大的值 
输入描述:
每个测试输入包含1个测试用例，第一行包括两个整数 N 和 D :
3 <= N <= 100
1 <= D <= N
接下来有N行，每行N个数字d:
0 <= d <= 100


输出描述:
输出一个整数，表示找到的和的最大值

输入例子1:
4 2
87 98 79 61
10 27 95 70
20 64 73 29
71 65 15 0

输出例子1:
193
 */

//Accepted 80%
namespace 二维数组连续N数最大和
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int D = 0;
            int[][] Matrix = null;
            ProcessInput(ref N, ref D, ref Matrix);
            
            List<List<int>> res = GetProcessedIntListFromMatrix(Matrix, N);
            int big = getBiggestSum(res, D);
            Console.WriteLine(big);
            Console.ReadLine();

        }


        static int getBiggestSum(List<List<int>> res,int D) 
        {
            List<int> bigSum = new List<int>();
            foreach (List<int> intList in res)
            {
                for (int i = 0; i < intList.Count - D; i++)
                {
                    int continusDSum = getContinuousSum(intList, i, D);
                    if (bigSum.Count == 0)
                        bigSum.Add(continusDSum);
                    else
                    {
                        if (continusDSum > bigSum[0])
                            bigSum[0] = continusDSum;
                    }
                }
            }
            if (bigSum.Count > 0)
                return bigSum[0];
            else
                throw new NotSupportedException();
        }

        static int getContinuousSum(List<int> intList,int startIndex,int D) 
        {
            int sum = 0;
            for (int i = 0; i < D; i++)
            {
                sum += intList[startIndex + i];
            }
            return sum;
        }

        static int[][] getInitializedMatrix(int N)
        {
            int[][] Matrix = new int[N][];
            for (int i = 0; i < N; i++)
            {
                Matrix[i] = new int[N];
            }
            return Matrix;
        }


        static List<List<int>> GetProcessedIntListFromMatrix(int[][] Matrix,int N)
        {
            List<List<int>> result = new List<List<int>>();

            //横向
            for (int i = 0; i < N; i++)
            {
                List<int> tmp = new List<int>();
                int j = 0;
                while (j < N)
                {
                    tmp.Add(Matrix[i][j]);
                    j++;
                }
                result.Add(tmp);
            }
            //纵向
            for (int i = 0; i < N; i++)
            {
                List<int> tmp = new List<int>();
                int j = 0;
                while (j < N)
                {
                    tmp.Add(Matrix[j][i]);
                    j++;
                }
                result.Add(tmp);
            }
            //\向
            {
                List<Point> naStartPoints = new List<Point>();
                for (int i = 0; i < N; i++)
                {
                    Point n = new Point(0, i);
                    if (!naStartPoints.Contains(n))
                        naStartPoints.Add(n);
                }
                for (int i = 0; i < N; i++)
                {
                    Point n = new Point(i, 0);
                    if (!naStartPoints.Contains(n))
                        naStartPoints.Add(n);
                }
                foreach (Point p in naStartPoints)
                {
                    List<int> tmp = new List<int>();
                    while (true)
                    {
                        if (p.x >= 0 && p.x < N && p.y >= 0 && p.y < N)
                        {
                            tmp.Add(Matrix[p.x][p.y]);
                            p.x++;
                            p.y++;
                        }
                        else
                        {
                            result.Add(tmp);
                            break;
                        }
                    }
                }
            }

            // /向
            {
                List<Point> naStartPoints = new List<Point>();
                for (int i = 0; i < N; i++)
                {
                    Point n = new Point(0, i);
                    if (!naStartPoints.Contains(n))
                        naStartPoints.Add(n);
                }
                for (int i = 0; i < N; i++)
                {
                    Point n = new Point(i, N-1);
                    if (!naStartPoints.Contains(n))
                        naStartPoints.Add(n);
                }
                foreach (Point p in naStartPoints)
                {
                    List<int> tmp = new List<int>();
                    while (true)
                    {
                        if (p.x >= 0 && p.x < N && p.y >= 0 && p.y < N)
                        {
                            tmp.Add(Matrix[p.x][p.y]);
                            p.x++;
                            p.y--;
                        }
                        else
                        {
                            result.Add(tmp);
                            break;
                        }
                    }
                }
            }
            return result;
        }
        class Point:IEquatable<Point>
        {
            public Point(int x, int y) { this.x = x; this.y = y;}
            public int x;
            public int y;
            public bool Equals(Point other)
            {
                Point compareObj = other as Point;
                if (compareObj.x == this.x && compareObj.y == this.y)
                    return true;
                else
                    return false;
            }
        }

        static void ProcessInput(ref int N,ref int D,ref int[][] Matrix) 
        {

            string str = Console.ReadLine();
            string[] strSplits = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            N = int.Parse(strSplits[0]);
            D = int.Parse(strSplits[1]);
            Matrix = getInitializedMatrix(N);
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                string[] splits = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < splits.Length;j++)
                {
                    int p = int.Parse(splits[j]);
                    Matrix[i][j] = p;
                }
            }
        }


    }
}
