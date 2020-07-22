using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x;
		x = Convert.ToInt32(Console.ReadLine());
		if( ((x % 4 == 0) && (x % 100 != 0)) || ((x % 100 == 0) && (x % 400 == 0)) )
	        Console.WriteLine("Leap year");
		else Console.WriteLine("Common year");
	}
}