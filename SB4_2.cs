using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int x, y;
		x = Convert.ToInt32(Console.ReadLine());
		y = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Sum:");
		Console.WriteLine(x + y);
		Console.WriteLine("Sub:");
		Console.WriteLine(x - y);
		Console.WriteLine("Mul:");
		Console.WriteLine(x * y);
		Console.WriteLine("Seg:");
		Console.WriteLine(x / y);
	}
}