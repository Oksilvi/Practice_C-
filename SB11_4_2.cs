using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N = Convert.ToInt32(Console.ReadLine());
		int k = 0;
		int [] array = new int[15];
		Random rand = new Random();
		for( int i = 0; i < 15; i++ )
		{
			k ++;
			array[i] = rand.Next(10) + 1;
			Console.WriteLine(array[i]);
			if( N == array[i] ) break;
		}
		if( k < 15 ) Console.WriteLine("Line:" + " " + k); else
		Console.WriteLine("No values");
	}
}