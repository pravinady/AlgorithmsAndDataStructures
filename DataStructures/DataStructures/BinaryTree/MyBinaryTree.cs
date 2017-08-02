using System;
namespace Practice.DataStructures
{
    public class MyBinaryTree<T>
    {
        public TreeNode<T> Root;

        public MyBinaryTree(T key)
        {
            Root = new TreeNode<T>(key);
        }

        #region Public Methods

        public void InorderTraversal()
        {
			Console.WriteLine("In order traversal of binary tree nodes");
			PrintInorder(Root);
        }

		public void PreorderTraversal()
		{
			Console.WriteLine("Pre order traversal of binary tree nodes");
			PrintPreorder(Root);
		}

		public void PostorderTraversal()
		{
			Console.WriteLine("Post order traversal of binary tree nodes");
			PrintPostorder(Root);
		}

        public void BreadthFirstTraversal()
        {
			Console.WriteLine("Breadth First Traversal of binary tree nodes");
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

        private void PrintBreadthFirstTraversal(TreeNode<T> root)
        {
            var queue = new MyQueue<TreeNode<T>>();
            Console.WriteLine(root.key);
            queue.Push(root);

            while (!queue.IsEmpty())
            {
                var node = queue.Pop();

                if(node.Data.Left != null)
                {
                    Console.WriteLine(node.Data.Left.key);
                    queue.Push(node.Data.Left);
                }
                if(node.Data.Right != null)
                {
                    Console.WriteLine(node.Data.Right.key);
                    queue.Push(node.Data.Right);
				}
            }
        }

        #endregion
    }
}
