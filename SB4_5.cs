using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int n;
		n = Convert.ToInt32(Console.ReadLine());
		n = n + 11 * n + 111 * n;
		Console.WriteLine(n);	
	}
}