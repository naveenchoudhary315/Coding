using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val)
        {
            this.val = val;
            left = null;
            right = null;
        }

    }

    internal class Microsoft_BinaryTree
    {
        public TreeNode root;
        public Microsoft_BinaryTree(TreeNode root)
        { 
            this.root = root; 
        }

        public TreeNode InsertNode(TreeNode node,int val) 
        {
            if(node == null) 
            {
                root = new TreeNode(val);
                return root;
            }

            if (root.val < val)
            {
               InsertNode(node.left,val);
            }
            if (root.val > val)
            {
                InsertNode(node.right, val);
            }
            return node;
        }

        public TreeNode SearchElement(TreeNode node,int val) 
        {
            if (root == null) return null;

            if (val < root.val)
            {
                SearchElement(node.left, val);
            }
            else if (val > root.val)
            {
                SearchElement(node.right, val);
            }
            return node;
        }
    }

   
}
