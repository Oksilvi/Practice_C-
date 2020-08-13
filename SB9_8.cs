using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int i, N, L, k, m;
		N = Convert.ToInt32(Console.ReadLine()); // quantity
		L = Convert.ToInt32(Console.ReadLine()); // price
		k = L; // max price
		m = L; // min price
		for( i = 2; i <= N; i ++ )
		{
			L = Convert.ToInt32(Console.ReadLine());
			if( L >= k ) 
				k = L; 
			if( L <= m ) m = L;
		}
		Console.WriteLine("Max" + " " + k + " " + " Min" + " " + m);
	}
}