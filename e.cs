using System;
using System.Linq;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			var matrix = new decimal[2, 2];
			
			
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					matrix[i, j] = decimal.Parse(Console.ReadLine());
				}
			}
			
			decimal sum = 0m;
			foreach (var a in matrix) {
				sum += a;
			}
			
			Console.WriteLine(sum / matrix.Length);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
