using System;
					
public class Program
{
	public static void Main()
	{
		bool x, y;
		x = true;
		y = false;
		Console.WriteLine((y || true) && x && !x);
	}
}