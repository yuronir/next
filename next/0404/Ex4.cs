using System;

namespace next
{
	public class Ex4
	{
		public static void SumPrint (int x, int y){
			int n = x + y;
			Console.WriteLine (n);
		}

		static void Main(string[] args){
			int x = 10;
			int y = 20;
			SumPrint (x, y);
		}
	}
}

