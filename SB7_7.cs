using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double x, n, W, L, H;
		x = Convert.ToDouble(Console.ReadLine());
		W = Convert.ToDouble(Console.ReadLine());
		L = Convert.ToDouble(Console.ReadLine());
		H = Convert.ToDouble(Console.ReadLine());
		n = (2 * H * (L + W)) / x;
		if( (2 * H * (L + W)) % x == 0 ) Console.WriteLine("Minimum" + " " + n); else
		Console.WriteLine("Minimum" + " " + n + " or " + (int) (n + 1)); 	
	}
}