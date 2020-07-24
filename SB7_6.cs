using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x;
		x = Convert.ToInt32(Console.ReadLine());
		if( x >= 1 && x <= 12 )
		{
			if( x == 1 || x == 2 || x == 12 ) Console.WriteLine("Winter"); else
		    if( x == 3 || x == 4 || x == 5 ) Console.WriteLine("Spring"); else
			if( x == 6 || x == 7 || x == 8 ) Console.WriteLine("Summer"); else
			Console.WriteLine("Autumn");
			if( x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12 ) Console.WriteLine("31"); else
			if( x == 4 || x == 6 || x == 9 || x == 11 ) Console.WriteLine("30"); else
			Console.WriteLine("29");
		}
		else Console.WriteLine("Unknown");
	}
}