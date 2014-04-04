using System;


namespace next
{
	public class Lab2
	{
		public static void Main()
		{
			int raw = ReadInt ("Raw");
			int column = ReadInt ("Column");

			for (int i = 0; i < raw; i++) {
				for (int j = 0; j < column; j++) {
					Console.Write ("{0}{1} ", i, j);
				}
				Console.WriteLine ("");
			}
		}

		public static int ReadInt(string msg){
			Console.Write(msg + " ");
			int x = int.Parse(Console.ReadLine());
			return x;
		}
	}
}
