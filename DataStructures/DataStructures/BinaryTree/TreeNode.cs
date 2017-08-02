using System;
namespace Practice.DataStructures
{
    public class TreeNode<T>
    {
        public T key;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T key)
        {
            this.key = key;
            Left = Right = null;
        }
    }
}
