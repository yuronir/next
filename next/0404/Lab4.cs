using System;

namespace next
{
	public class Next
	{
		public static int[] ReadInt (string msg){
		
			int[] arr;
			string temp;
			string[] tempString;

			Console.Write ("{0} : ", msg);
			temp = Console.ReadLine ();
			tempString = temp.Split ();
			arr = new int[tempString.Length];

			for (int i = 0; i < tempString.Length; i++) {
				arr[i] = (int.Parse(tempString[i]));
			}

			return arr;
		}
	}

	class Test{
		static void Main(string[] args){
			int[] arr = Next.ReadInt ("Input test Numbers");
			foreach (int i in arr) {
				Console.WriteLine (i);
			}
		}
	}
}

