using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double x, y, z, Portion;
		x = Convert.ToDouble(Console.ReadLine());
		y = Convert.ToDouble(Console.ReadLine());
		z = Convert.ToDouble(Console.ReadLine());
	    Portion = (x + y + z) / 3;
		Console.WriteLine(Portion);	
	}
}