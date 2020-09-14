using System;

public class Program
{
	public static void Main()
	{
		int[] array = new int[100];
		Random rand = new Random();
		int sum = 0, R = 0;
		double m = 0;
		for (int i = 0; i < 100; i++)
		{
			R = rand.Next(50) + 1;
			sum += R;
			m = i;
			Console.WriteLine(R);
		}
		Console.WriteLine("summa:" + " " + sum + " " + "mean" + " " + sum / (m + 1));
	}
}