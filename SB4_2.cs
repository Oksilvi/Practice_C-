using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int r;
		r = Convert.ToInt32(Console.ReadLine());
		double P, pi;
		pi = 3.14;
        P = 2 * pi * r;
		Console.WriteLine(P);	
	}
}