using System;
					
public class Program
{
	public static void Main()
	{
		string s1 = Convert.ToString(Console.ReadLine());
		string s2 = Convert.ToString(Console.ReadLine());
		char [] sy1 = s1.ToCharArray();
		char [] sy2 = s2.ToCharArray();
		int k = 0;
		for( int i = 0; i < s1.Length; i ++ )
		{
		     if( sy1 [i] != sy2 [i] ) 
		     {
		          k = i;
			  break;
		     }
		}
		if( k != 0 ) Console.WriteLine("Index: " + k); else
		Console.WriteLine("EQUALS");
	}
}