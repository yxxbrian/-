using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 输入一棵二叉搜索树，将该二叉搜索树转换成一个排序的双向链表。
 * 要求不能创建任何新的结点，只能调整树中结点指针的指向。
 */
namespace 二叉搜索树与双向链表
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            TreeNode L11 = new TreeNode(6);
            TreeNode L12 = new TreeNode(14);
            TreeNode L21 = new TreeNode(4);
            TreeNode L22 = new TreeNode(8);
            TreeNode L23 = new TreeNode(12);
            TreeNode L24 = new TreeNode(16);
            root.left = L11;
            root.right = L12;
            L11.left = L21;
            L11.right = L22;
            L12.left = L23;
            L12.right = L24;
            TreeNode result = new Solution().Convert(root);
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
            public TreeNode Convert(TreeNode pRootOfTree)
            {
                // write code here
                if (pRootOfTree == null)
                    return null;
                TreeNode left = null;
                TreeNode right = null;
                ConverAndReturnLR(ref pRootOfTree,ref  left,ref right);
                return left;
            }

            public void ConverAndReturnLR(ref TreeNode node,ref TreeNode left,ref TreeNode right)
            {
                if (node.left == null && node.right == null)
                {
                    left = node;
                    right = node;
                }
                else
                {
                    if (node.left != null)
                    {
                        TreeNode tmpLL = null;
                        TreeNode tmpLR = null;
                        ConverAndReturnLR(ref node.left, ref tmpLL, ref tmpLR);
                        tmpLR.right = node;
                        node.left = tmpLR;
                        left = tmpLL;
                    }
                    else
                        left = node;

                    if (node.right != null)
                    {
                        TreeNode tmpRL = null;
                        TreeNode tmpRR = null;
                        ConverAndReturnLR(ref node.right, ref tmpRL, ref tmpRR);
                        node.right = tmpRL;
                        tmpRL.left = node;
                        right = tmpRR;
                    }
                    else
                        right = node;
                }
            }
        }

    }
}
