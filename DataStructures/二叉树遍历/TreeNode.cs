using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树遍历
{
    class TreeNode
    {
        public TreeNode(int val) 
        {
            this.val = val;
        }

        public int val;
        TreeNode leftChild = null;
        TreeNode rightChild = null;
    }
}
