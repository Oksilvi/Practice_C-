using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x;
		x = Convert.ToInt32(Console.ReadLine()); 
	    if ( x == 1 ) Console.WriteLine("Monday"); else
		if ( x == 2 ) Console.WriteLine("Tuesday"); else
		if ( x == 3 ) Console.WriteLine("Wednesday"); else 
		if ( x == 4 ) Console.WriteLine("Thursday"); else
		if ( x == 5 ) Console.WriteLine("Friday"); else 
		if ( x == 6 ) Console.WriteLine("Saturday"); else
		if ( x == 7 ) Console.WriteLine("Sunday");  else 
		Console.WriteLine("Unknown"); 
	}
}