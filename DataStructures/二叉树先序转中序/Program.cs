using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树先序转中序
{

    //t#s#sqxj#gh#y#x#zm##c#f#llde##znq###q#x#y########
    class Program
    {
        class TreeNode
        {
            public TreeNode(char val)
            {
                this.val = val;
            }
            public char val;
            public TreeNode leftChild;
            public TreeNode rightChild;
        }

        static void Main(string[] args)
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine())) 
            {
                TreeNode tree = createTree(str);
                TraverseMid(tree);
                Console.WriteLine();
            }

        }

        static int index = 0;
        static TreeNode createTree(string str) 
        {
            index = 0;
            TreeNode tree = BuildTree(str);
            return tree;
        }

        static TreeNode BuildTree(string str) 
        {
            if (index >= str.Length || str[index] == '#')
            {
                index++;
                return null;
            }
            else
            {
                char c = str[index++];
                TreeNode t = new TreeNode(c);
                t.leftChild = BuildTree(str);
                t.rightChild = BuildTree(str);
                return t;
            }
        }

        static void TraverseMid(TreeNode node)
        {
            if (node != null)
            {
                TraverseMid(node.leftChild);
                Console.Write(node.val + " ");
                TraverseMid(node.rightChild);
            }
        }

        


    }
}
