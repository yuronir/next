using System;
using System.Collections.Generic;
using System.Linq;

namespace next
{
	public class Lab1
	{
		public static void Main ()
		{
			List<double> list = new List<double>();

			for (int i = 1; i <= 10; i++) {
				list.Insert (list.Count / 2, i/2);
			}
				
			foreach (double i in list) {
				Console.Write ("{0} ", i);
			}
		}
	}
}

