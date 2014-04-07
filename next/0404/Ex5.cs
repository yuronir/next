using System;

namespace next
{
	public class Ex5
	{
		public static int ReadInt (string msg){
			Console.Write ("{0}? ", msg);
			string r = Console.ReadLine ();
			int x = Convert.ToInt32 (r);
			return x;
		}

		public static double Divide(int x, int y){
			double r = (double)x / y;
			return r;
		}

		static void Main(string[] args){
			int a = ReadInt ("A");
			int b = ReadInt ("B");
			double x = Divide (a, b);
			Console.WriteLine (x);
		}
	}
}

