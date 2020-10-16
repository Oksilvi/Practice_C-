using System;
					
public class Program
{
	public static void Main()
	{
		int K = Convert.ToInt32(Console.ReadLine()); // measurement 1.1
		int L = Convert.ToInt32(Console.ReadLine()); // measurement 1.2
		int sum = 0;
		Random rand = new Random();
		int [,] array = new int[K,L];
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
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         if( x == y )
			     sum += array[x,y]; 
		     }
		}
		Console.WriteLine("Summa " + sum);
	}
}