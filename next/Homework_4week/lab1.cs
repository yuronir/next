using System;

namespace next
{
	class lab1
	{
		public static void Main ()
		{
			for (int i = 1; i < 6; i++) {
				for (int j = 0; j < i; j++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}
	}
}

