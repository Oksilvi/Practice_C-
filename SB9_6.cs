using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int X, Y, i, k;
		X = Convert.ToInt32(Console.ReadLine());
		Y = Convert.ToInt32(Console.ReadLine());
		k = 1;
		for( i = 1; i <= X; i ++ )
			if( X % i == 0 && Y % i == 0 ) 
				k = i;
		Console.WriteLine("Greatest common factor:" + " " + k);	
	}
}