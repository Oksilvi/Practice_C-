using System;

public class Program
{
	public static void Main()
	{
		int i;
		for (i = 0; i <= 11; i = i + 1)
		{
			if (i == 3 || i == 6) Console.WriteLine(); else
			Console.WriteLine(i);
		}
	}
}