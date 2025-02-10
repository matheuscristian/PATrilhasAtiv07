using System;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matrix = new int[3, 3];
			
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
