using System;

namespace next
{
	class Ex3
	{
		public static void Main(){
			const int SIZE = 5;
			int[] arr;
			int i, sum;
			arr = new int[SIZE];

			i = 0;
			while (i < SIZE) {
				Console.Write ("num[{0}]? ", i);
				String cmd = Console.ReadLine ();
				arr [i] = Convert.ToInt32 (cmd);
				i = i + 1;
			}

			i = 0;
			sum = 0;
			while (i < SIZE) {
				sum = sum + arr [i];
				i = i + 1;
			}

			Console.WriteLine ("Sum = {0} ", sum);
		}
	}
}

