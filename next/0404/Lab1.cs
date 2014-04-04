using System;

namespace next
{
	public class Lab1
	{
		public static void Main()
		{
			int count = ReadInt ("Input");
			for (int i = 0; i < count; i++) {
				for (int j = 1; j < count - i; j++) {
					Console.Write (" ");
				}

				for (int k = 0; k < 2*i+1; k++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}

		public static int ReadInt(string msg){
			Console.Write(msg + " ");
			int x = int.Parse(Console.ReadLine());
			return x;
		}
	}
}
