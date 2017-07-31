using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static void Main(String[] args)
	{
        //StairCase.PrintStairCase();
        //MinMaxSum.CalculateMinMaxSum();
        //BirthdayCakeCandles.CandlesBlowCount();

        PrintLinkedList();
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
}
