using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N = Convert.ToInt32(Console.ReadLine()); // number of cubes
		int M = Convert.ToInt32(Console.ReadLine()); // number of faces
		int result = 0;
		Random rand = new Random();
		for( int i = 1; i <= N; i ++ )
		{
		     M = rand.Next(M) + 1;
		     result += M;
		     Console.WriteLine(M);
		}
		Console.WriteLine("Result: " + result);
	}
}