using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, i;
		string result = "";
		N = Convert.ToInt32(Console.ReadLine());
		for( i = 1; i <= N; i = i * 2 )
			if ( N == i ) result = "Binary number"; else
			result = "Non-binary number";
		    Console.WriteLine(result);
	}
}