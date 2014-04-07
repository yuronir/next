using System;

namespace next
{
	public class Lab2
	{
		public static void Main ()
		{
			Console.Write ("정수를 입력해주세요 : ");
			int num = int.Parse(Console.ReadLine ());

			for (int i = 0; i < num+1; i++) {
				for (int j = 0; j < num; j++) {
					if (i <= j) {
						Console.Write ("*");
					} else {
						Console.Write ("#");
					}
				}
				Console.WriteLine ("");
			}
		}
	}
}

