using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x, y, a1, a2, a3, a4, b1, b2, b3, b4;
		x = Convert.ToInt32(Console.ReadLine()); // Year 1
		y = Convert.ToInt32(Console.ReadLine()); // Year 2
		a1 = x % 10;
		x = x / 10;
		a2 = x % 10;
		x = x / 10;
		a3 = x % 10;
		x = x / 10;
		a4 = x % 10;
        b1 = y % 10;
		y = y / 10;
		b2 = y % 10;
		y = y / 10;
		b3 = y % 10;
		y = y / 10;
		b4 = y % 10;
		if( a1 + a2 + a3 + a4 > b1 + b2 + b3 + b4 ) Console.WriteLine("Сompatible"); else
		Console.WriteLine("Not compatible");
	}
}