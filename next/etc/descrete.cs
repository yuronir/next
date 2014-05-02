using System;

namespace next
{
	public class descrete
	{
		public static void Main ()
		{
			int sum = 0;

			for (int i = 0; i < 1000; i++) {
				for (int j = 0; j < i; j++) {
					for (int k = 0; k < j; k++) {
						sum++;
					}
				}
			}

			Console.WriteLine (sum);
		}
	}
}

