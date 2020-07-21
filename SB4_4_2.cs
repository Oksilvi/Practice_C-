using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double x, y;
		x = Convert.ToDouble(Console.ReadLine());
		y = Convert.ToDouble(Console.ReadLine());
		x = y - x;
		y = y - x;
		x = x + y;
		Console.WriteLine("x = " + x);
		Console.WriteLine("y = " + y);
	}
}