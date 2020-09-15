using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N = Convert.ToInt32(Console.ReadLine());
		int R = 0, k = 0;
		int [] array = new int[15];
		Random rand = new Random();
		for( int i = 0; i < 15; i++ )
		{
			k ++;
			R = rand.Next(10) + 1;
			Console.WriteLine(R);
			if( N == R ) break;
		}
		if( N == R ) Console.WriteLine("Line:" + " " + k); else
		Console.WriteLine("No values");
	}
}