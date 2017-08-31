using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 从上往下打印二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node0 = new TreeNode(4);
            TreeNode node1 = new TreeNode(8);
            TreeNode node2 = new TreeNode(12);
            TreeNode node3 = new TreeNode(16);
            TreeNode node4 = new TreeNode(6);
            node4.left = node0;
            node4.right = node1;
            TreeNode node5 = new TreeNode(14);
            node5.left = node2;
            node5.right = node3;
            TreeNode root = new TreeNode(10);
            root.left = node4;
            root.right = node5;
            List<int> res = new Solution1().PrintFromTopToBottom(root);
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
        class Solution1
        {
            public List<int> PrintFromTopToBottom(TreeNode root)
            {
                List<TreeNode> treeNodes = new List<TreeNode>();
                if (root == null)
                    return new List<int>();
                treeNodes.Add(root);
                List<int> result = new List<int>();
                int i = 0;
                while (i < treeNodes.Count)
                {
                    result.Add(treeNodes[i].val);
                    if (treeNodes[i].left != null)
                        treeNodes.Add(treeNodes[i].left);
                    if (treeNodes[i].right != null)
                        treeNodes.Add(treeNodes[i].right);
                    i++;
                }
                return result;
            }
        }



        //37 ms	3056K
        class Solution
        {
            public List<int> PrintFromTopToBottom(TreeNode root)
            {
                
                // write code here
                List<int> returnResult = new List<int>();
                if (root == null)
                    return returnResult;
                Print(root, 0);
                Dictionary<int, List<int>> result = levelList.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
                //foreach()
                foreach (List<int> r in result.Values)
                    foreach (int v in r)
                        returnResult.Add(v);
                return returnResult;
            }

            public void Print(TreeNode node, int level)
            {
                pushData(level,node.val);
                if (node.left != null)
                    Print(node.left, level + 1);
                if (node.right != null)
                    Print(node.right, level + 1);
            }

            Dictionary<int, List<int>> levelList = new Dictionary<int, List<int>>();
            public void pushData(int level, int data)
            {
                if (!levelList.ContainsKey(level))
                    levelList.Add(level, new List<int>());
                levelList[level].Add(data);
            }

        }



    }
}
