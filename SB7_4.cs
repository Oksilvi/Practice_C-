using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x;
		x = Convert.ToInt32(Console.ReadLine());
		if (x % 2 == 0)
			Console.WriteLine("Even number");
		else Console.WriteLine("Odd number");
	}
}