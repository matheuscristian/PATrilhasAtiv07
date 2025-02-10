using System;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matrix = new int[10, 10];
			
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			
			for (int i = 0; i < 10; i++) {
				Console.Write(matrix[i, i] + " ");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
