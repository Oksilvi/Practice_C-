using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input");
		int N, i, a;
		N = Convert.ToInt32(Console.ReadLine()); // hour
		a = 0; // sum of natural divisors
		if (N >= 0 && N <= 24)
		{
			for (i = 0; i <= 24; i = i + 1)
				if (N == i && N % 2 == 0)
				{
					a = N / 2 + 2;
				}
			    if (N == i && N % 3 == 0)
			    {
				    a = N / 3 + 3;
			    }
			    Console.WriteLine(a);
			    if (a != 0 && a % 2 == 0) Console.WriteLine("Like"); else
				Console.WriteLine("Unlike");
		}
		else Console.WriteLine("Unknown");
	}
}