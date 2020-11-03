using System;
					
public class Program
{
	public static void Main()
	{
		string s1 = Convert.ToString(Console.ReadLine());
		string s2 = Convert.ToString(Console.ReadLine());
		int result = s1.IndexOf(s2);
		if( result > 0 )
		{
			Console.WriteLine("The second line is contained in the first");
		}
		else if( result < 0 ) 
		{
			Console.WriteLine("The second line is not contained in the first");
		}
		else 
		{
			Console.WriteLine("the second line is equal to the first line");
		}
	}
}