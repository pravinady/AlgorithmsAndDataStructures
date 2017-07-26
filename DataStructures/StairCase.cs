using System;

public class StairCase
{
    public static void PrintStairCase()
    {
		Console.WriteLine("-----------------------");
		Console.WriteLine("BUILD STAIR CASE");
		Console.WriteLine("-----------------------");
		
        Console.Write("Enter the number of floors for stair case: ");
		int n = Convert.ToInt32(Console.ReadLine());
		string s = string.Empty;

		for (int i = 0; i < n; i++)
		{
			for (int p = 0; p < (n - 1) - (i); p++)
			{
				s += " ";
			}
			for (int h = 0; h <= i; h++)
			{
				s += "#";
			}
			Console.WriteLine(s);
			s = string.Empty;
		}
    }
}