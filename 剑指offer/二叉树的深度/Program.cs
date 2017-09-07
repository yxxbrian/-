using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 输入一棵二叉树，求该树的深度。
 * 从根结点到叶结点依次经过的结点（含根、叶结点）形成树的一条路径，
 * 最长路径的长度为树的深度。
 */
namespace 二叉树的深度
{
    class Program
    {
        static void Main(string[] args)
        {

        }
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
        public int TreeDepth(TreeNode pRoot)
        {
            // write code here
            return getNextDepth(pRoot);
        }

        private int getNextDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                int left = getNextDepth(node.left);
                int right = getNextDepth(node.right);
                int res = 1 + Math.Max(left, right);
                return res;
            }
        }

    }


}
