using System;

namespace next
{
	public class Lab3
	{
		public static void Main ()
		{
			Console.Write ("배열 크기를 입력해주세요 : ");
			int size = int.Parse(Console.ReadLine ());
			string[] temp;
			string[,] arr = new string[size,size];

			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					arr [i, j] = "*";
				}
			}

			while(true){
				for (int i = 0; i < size; i++) {
					for (int j = 0; j < size; j++) {
						Console.Write ("{0} ", arr[i,j]);
					}
					Console.WriteLine ();
				}

				Console.Write ("지울 위치를 입력해주세요 : ");
				temp = Console.ReadLine ().Split();
				int x = int.Parse (temp [0]); int y = int.Parse (temp [1]);

				if (x < 1 || y < 1) {
					Console.WriteLine ("\n종료!\n");
					break;
				}

				if (arr [x-1, y-1].Equals ("*")) {
					arr [x-1, y-1] = " ";
					arr [y-1, x-1] = " ";
				} else {
					Console.WriteLine ("이미 지웠던 곳입니다!");
				}
			}
		}
	}
}

