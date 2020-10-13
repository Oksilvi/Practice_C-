using System;
					
public class Program
{
	public static void Main()
	{
		int M = Convert.ToInt32(Console.ReadLine()); // measurement 1
		int N = Convert.ToInt32(Console.ReadLine()); // measurement 2
		int [,] matrix = new int [M,N];
		for( int x = 0; x < M; x ++ ) 
		{
			for( int y = 0; y < N; y ++ )
			{				
		        matrix[x,y] = y;
				Console.Write(matrix[x,y] + " ");
			}
			Console.WriteLine();
		}
	}
}