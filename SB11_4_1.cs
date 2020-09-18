using System;

public class Program
{
	public static void Main()
	{
		int[] array = new int[100];
		Random rand = new Random();
		int sum = 0;
		double m = 0;
		for (int i = 0; i < 100; i++)
		{
			array[i] = rand.Next(50) + 1;
			Console.WriteLine(array[i]);
		}
		for (int i = 0; i < 100; i++)
		{
			sum += array[i];
			m = i;
		}
		Console.WriteLine("summa:" + " " + sum + " " + "mean" + " " + sum / (m + 1));
	}
}