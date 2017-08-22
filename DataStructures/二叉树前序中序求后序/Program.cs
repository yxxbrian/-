using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树前序中序求后序
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            string[] ss = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pre = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
                pre[i] = int.Parse(ss[i]);

            string[] sss = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tin = new int[sss.Length];
            for (int i = 0; i < sss.Length; i++)
                tin[i] = int.Parse(sss[i]);

            TreeNode tree = new Solution().reConstructBinaryTree(pre, tin);

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


        /*
         输入某二叉树的前序遍历和中序遍历的结果，请重建出该二叉树。假设输入的前序遍历和中序遍历的结果中都不含重复的数字。
         * 例如输入前序遍历序列{1,2,4,7,3,5,6,8}和中序遍历序列{4,7,2,1,5,3,8,6}，则重建二叉树并返回。
         */
        class Solution
        {
            public TreeNode reConstructBinaryTree(int[] pre, int[] tin)
            {
                // write code here
                return reConstructBinaryTree(pre, 0, pre.Length - 1, tin, 0, tin.Length - 1);
            }

            public TreeNode reConstructBinaryTree(int[] pre, int preStart, int preEnd, int[] tin, int inStart, int inEnd)
            {
                if (preStart > preEnd || inStart>inEnd)
                    return null;
                else
                {
                    TreeNode node = new TreeNode(pre[preStart]);
                    int leftNum = 0;
                    for (int i = inStart; i <= inEnd; i++)
                    {
                        if (tin[i] == pre[preStart])
                            leftNum = i - inStart;
                    }
                    node.left = reConstructBinaryTree(pre, preStart + 1, preStart + leftNum, tin, inStart, inStart + leftNum - 1);
                    node.right = reConstructBinaryTree(pre, preStart + leftNum + 1, preEnd, tin, inStart + leftNum + 1, inEnd);
                    return node;
                }   
            }

        }

    }
}
