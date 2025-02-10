using System;
using System.Linq;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [,] matrix = { { 1, 6, 3, 4 }, { 6, 3, 6, 1 }, { 7, 5, 3, 4 }, { 8, 6, 3, 5 } };
			
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++) {
					if (matrix[i, j] % 2 != 0) {
						Console.Write("* ");
						continue;
					}
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
