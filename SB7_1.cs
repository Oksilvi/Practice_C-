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
		if( x >= y && x >= z)
		{
		   if( y >= z )
		   Console.WriteLine("The biggest:" + " " + x + " " + "The smallest:" + " " + z + " " + "Difference:" + " " + x / z); else 
		   Console.WriteLine("The biggest:" + " " + x + " " + "The smallest:" + " " + y + " " + "Difference:" + " " + x / y);
		}
		else
		if( y >= x && y >= z)
		{
		   if( x >= z )
		   Console.WriteLine("The biggest:" + " " + y + " " + "The smallest:" + " " + z + " " + "Difference:" + " " + y / z); else 
		   Console.WriteLine("The biggest:" + " " + y + " " + "The smallest:" + " " + x + " " + "Difference:" + " " + y / x);
		}
		else
		if( z >= x && z >= y)
		{
		   if( x >= y )
		   Console.WriteLine("The biggest:" + " " + z + " " + "The smallest:" + " " + y + " " + "Difference:" + " " + z / y); else 
		   Console.WriteLine("The biggest:" + " " + z + " " + "The smallest:" + " " + x + " " + "Difference:" + " " + z / x);
		}
	}
}