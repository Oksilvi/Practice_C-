using System;
					
public class Program
{
    public static void Main()
    {
	 string s1 = "October";
	 char [] sy = s1.ToCharArray();
	 for( int i = 0; i < s1.Length / 2; i ++ )
	 {
	      char t = sy [i];
	      sy [i] = sy [s1.Length - 1 - i];
	      sy [s1.Length - 1 - i] = t;
	      s1 = new string(sy);
	  }
	  Console.WriteLine(s1); 
     }
}