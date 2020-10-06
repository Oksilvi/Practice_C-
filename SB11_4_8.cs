using System;
					
public class Program
{
	public static void Main()
	{
	        int[] array = new int[10];
	        Random rand = new Random();
		for (int i = 0; i < 10; i++)
		{
		     array[i] = rand.Next(20) + 1;
		     Console.WriteLine(array[i]);
		}
		Console.WriteLine("Bubble sort algorithm:");
		for( int i = 0; i < 10; i ++ )
		{	
		     for( int k = i + 1; k < 10; k ++ )
		     {
		          if( array[k] < array[i] )
			  {
			      int x = array[k];
			      array[k] = array[i];
			      array[i] = x;
			   }
		      }
		      Console.WriteLine(array[i]);
		}
	}
}