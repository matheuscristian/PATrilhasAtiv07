using System;

namespace yefgyigweig
{
	class Program
	{
		public static void Main(string[] args)
		{
			var nomes = new string[8];
			var produtos = new string[8, 4];
			var precos = new int[8, 4];
			
			for (int i = 0; i < 8; i++) {
				nomes[i] = Console.ReadLine();
				for (int j = 0; j < 4; j++) {
					produtos[i, j] = Console.ReadLine();
					precos[i, j] = int.Parse(Console.ReadLine());
				}
			}
			
			for (int i = 0; i < 8; i++) {
				Console.WriteLine(nomes[i]);
				for (int j = 0; j < 4; j++) {
					Console.WriteLine(produtos[i, j] + " - " + precos[i, j]);
				}
				Console.WriteLine("--------------");
			}
			
			
			Console.ReadKey();
		}
	}
}
