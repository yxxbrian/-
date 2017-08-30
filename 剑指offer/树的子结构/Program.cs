using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 树的子结构
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
            public bool HasSubtree(TreeNode pRoot1, TreeNode pRoot2)
            {
                // write code here
                if (pRoot2 == null)
                    return false;
                else if (pRoot1 == null)
                    return false;
                if (isSame(pRoot1, pRoot2))
                    return true;
                else
                    return (isSame(pRoot1.left, pRoot2) || isSame(pRoot1.right, pRoot2));
            }

            public bool isSame(TreeNode node1, TreeNode node2)
            {
                if (node2 != null && node1 != null && node1.val == node2.val)
                {
                    return (isSame(node1.left, node2.left) && isSame(node1.right, node2.right));
                }
                else if (node2 == null)
                    return true;
                else
                    return false;
            }

        }



    }
}
