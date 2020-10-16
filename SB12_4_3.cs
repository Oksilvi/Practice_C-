using System;
					
public class Program
{
	public static void Main()
	{
		int K = Convert.ToInt32(Console.ReadLine()); // measurement 1.1
		int L = Convert.ToInt32(Console.ReadLine()); // measurement 1.2
		Random rand = new Random();
		int [,] array1 = new int[K,L];
		int [,] array2 = new int[K,L];
		int [,] array3 = new int[K,L];
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         array1[x,y] = rand.Next(15) + 1;
		     }
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         Console.Write(array1[x,y] + " ");
		     }
		     Console.WriteLine(" ");
		}
		Console.WriteLine();
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         array2[x,y] = rand.Next(15) + 1;
		     }
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         Console.Write(array2[x,y] + " ");
		     }
		     Console.WriteLine(" ");
		}
		Console.WriteLine();
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         array3[x,y] = array1[x,y] + array2[x,y];
		     }
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         Console.Write(array3[x,y] + " ");
		     }
		     Console.WriteLine(" ");
		}
	}
}