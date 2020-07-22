using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double x, y;
		x = Convert.ToDouble(Console.ReadLine());
		y = Convert.ToDouble(Console.ReadLine());
		if ( (int) (x * 1000) == (int) (y * 1000) ) Console.WriteLine("Like"); else
		Console.WriteLine("Unequal");	
	}
}