using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x;
		x = Convert.ToInt32(Console.ReadLine());
		if( x % 5 == 0 && x % 11 == 0 ) Console.WriteLine("Human"); else
		Console.WriteLine("Zombie");	
	}
}