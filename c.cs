using System;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			var rand = new Random();
			
			int[,] matrix = new int[4, 2];
			
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 2; j++) {
					matrix[i, j] = rand.Next();;
				}
			}
			
			long sum = 0;
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 2; j++) {
					sum += matrix[i, j];
				}
			}
			
			Console.WriteLine(sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
