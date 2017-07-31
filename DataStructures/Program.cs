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
		var list = DataStructures.LinkedList.LinkedList.GetInstance();
		list.PrintNodes();

        list.AddNode(10);
        list.PrintNodes();

        list.AddNode(20);
        list.AddNode(30);

        list.PrintNodes();
    }
}
