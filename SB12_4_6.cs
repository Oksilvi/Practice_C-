using System;
					
public class Program
{
	public static void Main()
	{
		int K = Convert.ToInt32(Console.ReadLine()); // measurement 1
		int L = Convert.ToInt32(Console.ReadLine()); // measurement 2
		Random rand = new Random();
		int [,] array = new int[K,L];
		int [,] array0 = new int[L, K];
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         array[x,y] = rand.Next(15) + 1;
		     }
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		          Console.Write(array[x,y] + " ");
		     }
		     Console.WriteLine(" ");
		}
		Console.WriteLine();

		for( int y = 0; y < L; y ++ ) 
		{
		     for( int x = 0; x < K; x ++ )
		     {	
			  array0[y,x] = array[x,y];
		     }
		}
		for( int y = 0; y < L; y ++ ) 
		{
		     for( int x = 0; x < K; x ++ )
		     {	
		          Console.Write(array0[y,x] + " ");
		     }
		     Console.WriteLine(" ");
		}
	}
}