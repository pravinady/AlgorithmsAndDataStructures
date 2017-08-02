using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Practice.DataStructures;

namespace Practice.DataStructures
{
    public class Solution
    {

        static void Main(String[] args)
        {
            //StairCase.PrintStairCase();

            //MinMaxSum.CalculateMinMaxSum();

            //BirthdayCakeCandles.CandlesBlowCount();

            //PrintLinkedList();

            //PrintQueue();

            PrintBinaryTree();

        }

        private static void PrintLinkedList()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PRINT ELEMENTS IN LINKED LIST");
            Console.WriteLine("-----------------------------------");

            var list = new MyLinkedList<int>();

            list.AddNodeToEnd(20);
            list.PrintNodes();

            list.AddNodeToFront(10);
            list.PrintNodes();

            list.AddNodeAfter(10, 30);
            list.AddNodeAfter(20, 40);
            list.PrintNodes();

            list.DeleteNode(10);
            list.PrintNodes();

            list.DeleteNode(20);
            list.PrintNodes();

            list.DeleteNode(40);
            list.PrintNodes();

            list.DeleteNode(30);
            list.PrintNodes();
        }

        private static void PrintQueue()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PRINT ELEMENTS IN QUEUE");
            Console.WriteLine("-----------------------------------");

            var list = new MyQueue<int>();

            list.Push(20);
            list.Push(10);
            list.PrintNodes();

            list.Pop();
            list.PrintNodes();
        }

        private static void PrintBinaryTree()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("PRINT ELEMENTS IN BINARY TREE");
            Console.WriteLine("-----------------------------------");
            /*
                tree
                ----
                   1 < --root
                 /   \
                2     3
                /
                4
            */

            var binaryTree = new MyBinaryTree<int>(1);
            binaryTree.Root.Left = new TreeNode<int>(2);
            binaryTree.Root.Left.Left = new TreeNode<int>(4);
            binaryTree.Root.Right = new TreeNode<int>(3);

            Console.WriteLine("In order traversal of binary tree nodes");
            binaryTree.InorderTraversal();
            Console.WriteLine();

            Console.WriteLine("Pre order traversal of binary tree nodes");
            binaryTree.PreorderTraversal();
            Console.WriteLine();

            Console.WriteLine("Post order traversal of binary tree nodes");
            binaryTree.PostorderTraversal();

   //         var binaryTree = new BinaryTree<string>("apple");
			//binaryTree.Root.Left = new TreeNode<string>("banana");
			//binaryTree.Root.Left.Left = new TreeNode<string>("dog");
			//binaryTree.Root.Right = new TreeNode<string>("mat");

			//Console.WriteLine("In order traversal of binary tree nodes");
			//binaryTree.InorderTraversal();
			//Console.WriteLine();

			//Console.WriteLine("Pre order traversal of binary tree nodes");
			//binaryTree.PreorderTraversal();
			//Console.WriteLine();

			//Console.WriteLine("Post order traversal of binary tree nodes");
			//binaryTree.PostorderTraversal();
        }
    }
}
