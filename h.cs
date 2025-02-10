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
			
			long sum_p = 0;
			for (int i = 0; i < 10; i++) {
				sum_p += matrix[i, i];
			}
			
			long sum_s = 0;
			for (int i = 0; i < 10; i++) {
				for (int j = 9; j > -1; j--) {
					sum_s += matrix[i, j];
				}
			}
			
			Console.WriteLine(sum_p + " " + sum_p / 10);
			Console.WriteLine(sum_s + " " + sum_s / 10);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
