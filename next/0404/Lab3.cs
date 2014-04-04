using System;

namespace next
{
	public class Lab3
	{
		public static int[,,] array;
		public static int[,] arraySum;

		public static void Main ()
		{
			int size = ReadInt ("Input Array Size?");
			const int arrSize = 2;

			array = new int[arrSize, size, size];
			arraySum = new int[size, size];

			setArray (arrSize, size);
			writeArray(arrSize, size);
		}

		public static int ReadInt(string msg){
			Console.Write(msg + " ");
			int x = int.Parse(Console.ReadLine());
			return x;
		}

		public static void setArray(int arrSize, int size){
			for (int arrNum = 0; arrNum < arrSize; arrNum++) {

				Console.WriteLine ("Input array {0} ({1} * {2})", arrNum+1, size, size);

				for (int i = 0; i < size; i++) {

					//for each raw, need exception
					Console.Write ("{0}번째 Array의 {1}번째 행을 입력하세요({2}열) : ", arrNum + 1, i, size);
					String line = Console.ReadLine ();
					String[] tempArr = line.Split ();

					for (int j = 0; j < size; j++) {
						array [arrNum, i, j] = int.Parse (tempArr [j]);
						arraySum [i, j] += array [arrNum, i, j];
						//for each number
						//array[arrNum, i, j] = ReadInt (i + "" + j + "?");
						//arraySum [i, j] += array [arrNum, i, j];
					}
				}
			}
		}

		public static void writeArray(int arrSize, int size){
			for (int arrNum = 0; arrNum < arrSize; arrNum++) {
				for (int i = 0; i < size; i++) {

					Console.Write ("| ");

					for (int j = 0; j < size; j++) {
						Console.Write (array [arrNum, i, j] + " ");
					}

					Console.WriteLine ("|");
				}
				Console.WriteLine ("");
			}

			for (int i = 0; i < size; i++) {
				Console.Write ("| ");

				for (int j = 0; j < size; j++) {
					Console.Write (arraySum [i, j] + " ");
				}

				Console.WriteLine ("|");
			}

			Console.WriteLine ("123");
		}
	}
}

