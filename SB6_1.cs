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
		if( x >= y && x >= z) Console.WriteLine(x); else
		if( y >= x && y >= z) Console.WriteLine(y); else
		Console.WriteLine(z);
	}
}