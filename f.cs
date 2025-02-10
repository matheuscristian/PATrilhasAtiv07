using System;
using System.Linq;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			var rand = new Random();
			
			var matrix = new int[3, 3];
			
			int max = int.MinValue;
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					matrix[i, j] = rand.Next(1, 101);
					if (matrix[i, j] > max) {
						max = matrix[i, j];
					}
				}
			}
			
			Console.WriteLine(max);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
