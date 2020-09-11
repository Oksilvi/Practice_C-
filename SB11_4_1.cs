using System;
					
public class Program
{
	public static void Main()
	{
		int [] array = new int [100];
		{
			Random rand = new Random();
		        for( int i = 0; i < 100; i ++ )
				Console.WriteLine(rand.Next(50) + 1);
		}
	}
}