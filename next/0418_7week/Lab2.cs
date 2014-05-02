using System;
using System.Collections.Generic;
using System.Linq;

namespace next
{
	public class Lab2
	{
		public static void Main ()
		{
			List<int> list = new List<int> ();
			int input;

			while (true) {
				input = int.Parse (Console.ReadLine ());

				if (input == -999) {
					break;
				} else if (list.IndexOf (input) == -1) {
					list.Add (input);
				} else {
					list.Remove (input);
				}

				foreach (int i in list) {
					Console.Write ("{0} ", i);
				}

				Console.WriteLine ();
			}
		}
	}
}

