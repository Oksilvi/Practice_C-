using System;

public class Program
{
	public static void Main()
	{
		int K1 = Convert.ToInt32(Console.ReadLine()); // measurement 1.1
		int L1 = Convert.ToInt32(Console.ReadLine()); // measurement 1.2
		int M1 = Convert.ToInt32(Console.ReadLine()); // measurement 1.3
		int K2 = Convert.ToInt32(Console.ReadLine()); // measurement 2.1
		int L2 = Convert.ToInt32(Console.ReadLine()); // measurement 2.2
		int M2 = Convert.ToInt32(Console.ReadLine()); // measurement 2.3
		Random rand = new Random();
		int[,,] array1 = new int[K1, L1, M1];
		int[,,] array2 = new int[K2, L2, M2];
		for (int x = 0; x < K1; x++)
		{
			for (int y = 0; y < L1; y++)
			{
				for (int z = 0; z < M1; z++)
				{
					array1[x, y, z] = rand.Next(15) + 1;
				}
			}
		}
		for (int x = 0; x < K1; x++)
		{
			for (int y = 0; y < L1; y++)
			{
				for (int z = 0; z < M1; z++)
				{
					Console.Write(array1[x, y, z] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(" ");
		}

		if (K1 == K2 && L1 == L2 && M1 == M2)
		{
			for (int x = 0; x < K2; x++)
			{
				for (int y = 0; y < L2; y++)
				{
					for (int z = 0; z < M2; z++)
					{
						array2[x, y, z] = rand.Next(15) + 1;
						if (array1[x, y, z] != array2[x, y, z])
						{
							Console.WriteLine("Arrays are not equal");
							return;
						}
					}
				}
			}
			Console.WriteLine("Arrays are equal");
		}
		else Console.WriteLine("Arrays are not equal");
	}
}