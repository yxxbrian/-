using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 输入一棵二叉树，判断该二叉树是否是平衡二叉树。
 */
namespace 平衡二叉树
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
        public bool IsBalanced_Solution(TreeNode pRoot)
        {
            // write code here
            if (pRoot == null)
                return false;
            getNextDepth(pRoot);
            return valid;

        }
        bool valid = true;
        private int getNextDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                int left = getNextDepth(node.left);
                int right = getNextDepth(node.right);
                if (Math.Abs(left - right) > 1)
                    valid = false;
                int res = 1 + Math.Max(left, right);
                return res;
            }
        }

    }


}
