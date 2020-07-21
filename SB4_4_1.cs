using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double x, y, z;
		x = Convert.ToDouble(Console.ReadLine());
		y = Convert.ToDouble(Console.ReadLine());
		z = Convert.ToDouble(Console.ReadLine());
		y = x;
		x = z;
		z = y;
		Console.WriteLine("x = " + x);
		Console.WriteLine("z = " + z);
	}
}