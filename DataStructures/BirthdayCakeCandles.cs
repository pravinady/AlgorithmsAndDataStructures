using System;
using System.Linq;

public class BirthdayCakeCandles
{
    public static void CandlesBlowCount()
    {
		Console.WriteLine("-----------------------------------");
		Console.WriteLine("NUMBER OF CANDLES I CAN BLOW");
		Console.WriteLine("-----------------------------------");
        Console.WriteLine("Enter the number of candles");

		int n = Convert.ToInt32(Console.ReadLine());
		string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = ar_temp.Select(x=>Convert.ToInt32(x)).ToArray();

        int result = 0;
        int max = ar[0];
        for (int i = 0; i < n; i++)
        {
            if(ar[i] > max)
            {
                max = ar[i];
                result = 0;
            }
            if(ar[i]==max)
            {
                result++;
            }
        }
		Console.WriteLine(result);
    }

}