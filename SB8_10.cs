using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input");
		string x = "Geranium", y = "Violet", z = "Cactus", k = "";
		int N, i;
		N = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= N; i = i + 1)
		{
			k = z;
			z = y;
			y = k;
			k = x;
			x = y;
			y = k;
		}
		Console.WriteLine(x + " " + y + " " + z);
		Console.ReadKey();
	}
}