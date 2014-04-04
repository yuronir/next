using System;

namespace next
{
	public class Ex1
	{
		public static void Line ()
		{
			int x = int.Parse (Console.ReadLine ());

			for (int i = 0; i < x; i++) {
				Console.WriteLine ("---------------------------------------");
			}
		}

		public static void Main(string[] args){
			Console.Write ("Number? ");
			Line();
			Console.Write ("Another Number? ");
			Line();
			Console.WriteLine ("End");
		}
	}
}

