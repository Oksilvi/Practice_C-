using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x, y, z;
		x = Convert.ToInt32(Console.ReadLine());
		y = Convert.ToInt32(Console.ReadLine());
		z = Convert.ToInt32(Console.ReadLine());
		if( x == y && x == z ) Console.WriteLine("all equals"); else
		if( x != y && x != z && y != z ) Console.WriteLine("all different"); else
		Console.WriteLine("equal or different");
	}
}