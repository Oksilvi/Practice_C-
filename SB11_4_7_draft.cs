using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int S = Convert.ToInt32(Console.ReadLine()); // array size
		int [] array1 = new int[S];
		int [] array2 = new int[S];
		Random rand = new Random();
		Console.WriteLine("Array1:");
		for( int i = 0; i < S; i ++ )
		{
			array1[i] = rand.Next(25) + 1;
			Console.WriteLine(array1[i]);
		}
		Console.WriteLine("Array2:");
		for( int k = 0; k < S; k ++ )
		{
			array2[k] = rand.Next(25) + 1;
			Console.WriteLine(array2[k]);
		}
		Console.Write("The same:");
		for( int i = 0; i < S; i ++ )
		{
			for( int k = 0; k < S; k ++ )
		    {
			  if( array2[k] == array1[i] )	
			      Console.Write( array2[k] + " " );
			}
		} 
	}
}