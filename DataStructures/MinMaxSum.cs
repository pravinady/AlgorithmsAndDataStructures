using System;
using System.Linq;

public class MinMaxSum
{
    public static void CalculateMinMaxSum()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Calculate MIN MAX SUM");
		Console.WriteLine("-----------------------");

		Console.Write("Enter A single line of five space-separated integers: ");
		string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = arr_temp.Select(x => Convert.ToInt32(x)).ToArray();

        long sum = 0;
        long min = arr[0];
        long max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if(arr[i] < min)
            {
                min = arr[i];
            }
            if(arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine((sum-max) + " " + (sum-min));
    }
}