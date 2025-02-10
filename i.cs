using System;
using System.Linq;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			var matrix = new int[10, 10];
			
			
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			
			long sum = 0;
			foreach (var a in matrix) {
				sum += a;
			}
			
			Console.WriteLine(sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
