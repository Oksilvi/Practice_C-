using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		double pi;
		pi = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine( 3.1405 <= pi && pi <= 3.1423 );
	}
}