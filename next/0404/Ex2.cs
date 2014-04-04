using System;

namespace next
{
	public class Ex2
	{
		public static void Metho1 (){
			int x = 50;
			Console.WriteLine ("Metho1 x: {0}", x);
		}

		static void Main(string[] args){
			int x = 20;
			Console.WriteLine ("Main x: {0}", x);
			Metho1 ();
			Console.WriteLine ("Main x: {0}", x);
		}
	}
}

