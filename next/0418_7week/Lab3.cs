using System;
using System.Collections.Generic;
using System.Linq;

namespace next
{
	public class Lab3
	{
		public static void Main()
		{
			List<int> list = new List<int>();

			for (int i = 1; i <= 10; i++) {
				list.Add (i);
			}

			foreach(int i in list){
				Console.Write ("{0} ", i);
			}
			Console.WriteLine ();

			while (true) {
				swap (list);
				printList(list);
			}
		}

		static void printList(List<int> l){
			foreach(int i in l){
				Console.Write ("{0} ", i);
			}
			Console.WriteLine ();
		}

		public static void swap(List<int> l){

			int i1, i2, pos1, pos2;
			string[] temp = Console.ReadLine ().Split(new char[]{' '});
			pos1 = int.Parse (temp [0]) -1;
			pos2 = int.Parse (temp [1]) -1;

			Console.WriteLine ("loc1 = {0}, loc2 = {1}", pos1, pos2);

			i1 = l.ElementAt (pos1);
			i2 = l.ElementAt (pos2);

			Console.WriteLine ("i1 = {0}, i2 = {1}", i1, i2);

			l.RemoveAt (pos1); l.Insert (pos1, i2);
			l.RemoveAt (pos2); l.Insert (pos2, i1);
		}
	}
}

