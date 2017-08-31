using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 输入一颗二叉树和一个整数，打印出二叉树中结点值的和为输入整数的所有路径。
 * 路径定义为从树的根结点开始往下一直到叶结点所经过的结点形成一条路径。
 
 */
namespace 二叉树中和为某一值的路径
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            {
                val = x;
            }
        }

        class Solution
        {
            public List<List<int>> FindPath(TreeNode root, int expectNumber)
            {
                // write code here
                if (root != null)
                {
                    if (root.left == null && root.right == null && root.val == expectNumber)
                    {
                        List<List<int>> t = new List<List<int>>();
                        t.Add(new List<int>() { root.val });
                        return t;
                    }
                    List<List<int>> nextResult = new List<List<int>>();
                    if (root.left != null)
                        nextResult.AddRange(FindPath(root.left, expectNumber - root.val));
                    if (root.right != null)
                        nextResult.AddRange(FindPath(root.right, expectNumber - root.val));

                    foreach (List<int> item in nextResult)
                        item.Insert(0, root.val);
                    return nextResult;
                }
                return new List<List<int>>();
            }


        }




    }
}
