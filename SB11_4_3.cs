using System;
					
public class Program
{
	public static void Main()
	{
		int [] array = new int[15];
		Random rand = new Random();
		array[0] = rand.Next(30) + 1;
		int max = array[0], min = array[0];
		for( int i = 0; i < 15; i ++ )
		{
			array[i] = rand.Next(30) + 1;
			Console.WriteLine(array[i]);
			if( array[i] > max )
			    max = array[i];
			if( array[i] < min ) 
			    min = array[i];
		}
		Console.WriteLine("Min:" + " " + min + " " + "Max:" + " " + max);
	}
}