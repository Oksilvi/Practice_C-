using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int i, N, k;
		string result = "";
		N = Convert.ToInt32(Console.ReadLine()); // quantity of routers
		for( i = 1; i <= N; i ++)
		{
			Console.Write("Code:");
		    k = Convert.ToInt32(Console.ReadLine()); // code
			if( k == 171 ) 
			   {
			        result = ("Vulnerability:" + " " + i + " " + "router"); 
				    break; 
			   }
			else result = ("No Vulnerability "); 
		}
		 Console.Write(result);
	}
}