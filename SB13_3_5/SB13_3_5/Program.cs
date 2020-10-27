using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB13_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
			string s1 = Convert.ToString(Console.ReadLine());
			string s2 = Convert.ToString(Console.ReadLine());
			string s3 = $"{s1} {s2}";
			Console.Write(s3);
			Console.ReadKey();
		}
    }
}
