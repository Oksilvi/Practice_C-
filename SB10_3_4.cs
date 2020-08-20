using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
            int N, N1, Q, k, s, sum;
            N = Convert.ToInt32(Console.ReadLine()); // original number
            Q = Convert.ToInt32(Console.ReadLine()); // deleted digit
            N1 = N;
            sum = 0; // new number
            k = 0; // digits number
            for ( s = 10; s <= N; s *= 10)
            {
                k = N1 % 10;
                N1 /= 10;
                if (k == Q) { k = 0; s /= 10; }
                k *= s / 10;
                sum += k;
            }
            Console.Write(sum);
	}
}