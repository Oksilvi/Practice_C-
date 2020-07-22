using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("1th time:");
		int x, y, z, t;
		x = Convert.ToInt32(Console.ReadLine());
		y = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("2sd time:");
		z = Convert.ToInt32(Console.ReadLine());
		t = Convert.ToInt32(Console.ReadLine());
		if( (x + t) > (y + z) ) Console.WriteLine("Russian - winner"); else
		if( (x + t) < (y + z) ) Console.WriteLine("Brazil - winner"); else
		Console.WriteLine("Dead heat");	
	}
}