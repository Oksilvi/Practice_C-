using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N;
		N = Convert.ToInt32(Console.ReadLine());
		do
		{
			N --; 
			Console.WriteLine(N);
		}
		while( N > 1 );
	}
}