using System;
using System.Collections.Generic;
using System.Linq;

namespace next
{
	public class Lab1
	{
		public static void Main()
		{
			int ran;
			List <int> ll = new List<int> ();
			for (int i = 1; i <= 10; i++)
				ll.Add (i);

			Random rd = new Random ();

			for (int i = 9; i > 0; i--) {
				ran = rd.Next (0, i);
				swap (ll, i, ran);
			}

			foreach (int i in ll)
				Console.Write (i + " ");
		}

		static void swap(List<int> n, int Ran1, int Ran2)
		{
			int v1 = n.ElementAt(Ran1);
			int v2 = n.ElementAt(Ran2);
			n.RemoveAt(Ran1);
			n.Insert(Ran1, v2);
			n.RemoveAt (Ran2);
			n.Insert(Ran2, v1);
		}
	}
}