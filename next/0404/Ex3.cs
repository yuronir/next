using System;

namespace next
{
	public class Ex3
	{
		public static void DoublePrint(int x){
			int n = 2 * x;
			Console.WriteLine (n);
		}

		static void Main (string[] args){
			int x = 10;
			int y = 20;
			DoublePrint (x);
			DoublePrint (y);
			DoublePrint (30);
			Console.WriteLine ("Main x : {0}", x);
		}
	}
}

