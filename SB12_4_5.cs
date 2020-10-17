using System;
					
public class Program
{
	public static void Main()
	{
		int K = Convert.ToInt32(Console.ReadLine()); // measurement 1.1
		int L = Convert.ToInt32(Console.ReadLine()); // measurement 1.2
		Random rand = new Random();
		int [,] matrix = new int[K,L];
		int [] array1 = new int[K];
		int [] array2 = new int[L];
		int sum1 = 0, sum2 = 0;
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		         matrix[x,y] = rand.Next(15) + 1;
		     }
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		        Console.Write(matrix[x,y] + " ");
		     }
		     Console.WriteLine();
		}

		Console.WriteLine("x-axis sum");
		for( int x = 0; x < K; x ++ ) 
		{
		     for( int y = 0; y < L; y ++ )
		     {	
		          array1[x] += matrix[x,y];
	             }
		     Console.WriteLine(array1[x]);
		}
		for( int x = 0; x < K; x ++ ) 
		{
		     sum1 += array1[x];
		}
		Console.WriteLine("Sum1 " + sum1);

		Console.WriteLine("y-axis sum");
		for( int y = 0; y < L; y ++ ) 
		{
		     for( int x = 0; x < K; x ++ )
		     {	
		          array2[y] += matrix[x,y];
		     }
		     Console.WriteLine(array2[y]);
		}
		for( int y = 0; y < L; y ++ ) 
		{
		     sum2 += array2[y];
		}
		Console.WriteLine("Sum2 " + sum2);
		if( sum1 == sum2 ) Console.WriteLine("Balance"); else
		Console.WriteLine("Not Balance");
	}
}