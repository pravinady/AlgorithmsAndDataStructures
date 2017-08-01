using System;
namespace Practice.DataStructures.BinaryTree
{
    public class TreeNode
    {
        public int key;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int key)
        {
            this.key = key;
            Left = Right = null;
        }
    }
}
