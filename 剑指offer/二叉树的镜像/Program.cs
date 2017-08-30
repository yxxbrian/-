using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树的镜像
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
            public TreeNode Mirror(TreeNode root)
            {
                // write code here
                if (root == null)
                    return null;
                else
                {
                    TreeNode left = root.left;
                    TreeNode right = root.right;
                    root.left = Mirror(right);
                    root.right = Mirror(left);
                    return root;
                }
            }


        }

    }
}
