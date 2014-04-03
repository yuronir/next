using System;

namespace next
{
	class lab3
	{
		public static void Main ()
		{
			int i = 1;
			do {
				int j = 0;
				do {
					Console.Write ("*");
					j++;
				} while(j < i);
				Console.WriteLine("");
				i++;
			} while(i < 6);

			Console.WriteLine ("");

			int k = 5;
			do {
				int l = 0;
				do {
					Console.Write ("*");
					l++;
				} while(l < k);
				Console.WriteLine("");
				k--;
			} while(k > 0);
		}
	}
}

