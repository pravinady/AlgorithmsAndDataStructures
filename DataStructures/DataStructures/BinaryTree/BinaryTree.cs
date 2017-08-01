using System;
namespace Practice.DataStructures.BinaryTree
{
    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree(int key)
        {
            Root = new TreeNode(key);
        }

        #region Depth First Traversal

        public void PrintInorder(TreeNode r)
        {
            if(r == null)
            {
                return;
            }

            PrintInorder(r.Left);
            Console.Write(r.key + " ");
            PrintInorder(r.Right);
        }

		public void PrintPreorder(TreeNode r)
		{
			if (r == null)
			{
				return;
			}
			
            Console.Write(r.key + " ");
			PrintInorder(r.Left);
			PrintInorder(r.Right);
		}

		public void PrintPostorder(TreeNode r)
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
	}
}
