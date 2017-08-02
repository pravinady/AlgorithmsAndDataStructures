using System;
namespace Practice.DataStructures
{
    public class BinaryTree<T>
    {
        public TreeNode<T> Root;

        public BinaryTree(T key)
        {
            Root = new TreeNode<T>(key);
        }

        #region Public Methods

        public void InorderTraversal()
        {
            PrintInorder(Root);
        }

		public void PreorderTraversal()
		{
            PrintPreorder(Root);
		}

		public void PostorderTraversal()
		{
            PrintPostorder(Root);
		}

        public void BreadthFirstTraversal()
        {
            PrintBreadthFirstTraversal(Root);
        }

        #endregion

        #region Depth First Traversal

        private void PrintInorder(TreeNode<T> r)
        {
            if (r == null)
            {
                return;
            }

            PrintInorder(r.Left);
            Console.Write(r.key + " ");
            PrintInorder(r.Right);
        }

        private void PrintPreorder(TreeNode<T> r)
        {
            if (r == null)
            {
                return;
            }

            Console.Write(r.key + " ");
            PrintInorder(r.Left);
            PrintInorder(r.Right);
        }

        private void PrintPostorder(TreeNode<T> r)
        {
            if (r == null)
            {
                return;
            }

            PrintInorder(r.Left);
            PrintInorder(r.Right);
            Console.Write(r.key + " ");
        }

        #endregion

        #region Breadth First Traversal

        private void PrintBreadthFirstTraversal(TreeNode<T> r)
        {
            
        }

        #endregion
    }
}
