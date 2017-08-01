using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Practice.DataStructures.BinaryTree;

class Solution
{

	static void Main(String[] args)
	{
        //StairCase.PrintStairCase();

        //MinMaxSum.CalculateMinMaxSum();

        //BirthdayCakeCandles.CandlesBlowCount();

        //PrintLinkedList();

        PrintBinaryTree();
    }

    private static void PrintLinkedList()
    {
		Console.WriteLine("-----------------------------------");
		Console.WriteLine("PRINT ELEMENTS IN LINKED LIST");
		Console.WriteLine("-----------------------------------");

        var list = new DataStructures.LinkedList.LinkedList();

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

        var binaryTree = new BinaryTree(1);
		binaryTree.Root.Left = new TreeNode(2);
        binaryTree.Root.Left.Left = new TreeNode(4);
        binaryTree.Root.Right = new TreeNode(3);

        Console.WriteLine("In order traversal of binary tree nodes");
        binaryTree.PrintInorder(binaryTree.Root);
        Console.WriteLine();
		
        Console.WriteLine("Pre order traversal of binary tree nodes");
        binaryTree.PrintPreorder(binaryTree.Root);
		Console.WriteLine();

		Console.WriteLine("Post order traversal of binary tree nodes");
        binaryTree.PrintPostorder(binaryTree.Root);
    }
}
