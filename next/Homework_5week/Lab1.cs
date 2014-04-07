using System;

namespace next
{
	public class Lab1
	{
		public static void Main (string[] args)
		{
			Console.Write ("행 수와 열 수를 각각 입력해주세요 : ");
			string[] temp = Console.ReadLine ().Split();

			for (int i = 1; i <= int.Parse(temp [0]); i++) {
				for (int j = 1; j <= int.Parse(temp [1]); j++) {
					Console.Write (i * j + " ");
				}
				Console.WriteLine ("");
			}
		}
	}
}

