using System;
					
public class Program
{
	public static void Main()
	{
	    string s1 = "aenit aip aoo aoom";
	    char [] sy = s1.ToCharArray();
	    for( int i = 0; i < s1.Length; i ++ )
	    {
	         if( sy [i] == 'a') 
		 sy [i] = 'z';
	         s1 = new string(sy);
	    }
	    Console.WriteLine(s1); 
	}
}