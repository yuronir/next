using System;

namespace next
{
	public class Puzzle
	{
		public static void Main ()
		{
			const int puzSize = 3;

			object[,] puzzle = new object[puzSize, puzSize];

			initPuzzle (puzSize, puzzle);
			viewPuzzle (puzSize, puzzle);
			startPuzzle (puzSize, puzzle);
		}

		//Reset Puzzle
		public static object[,] initPuzzle(int puzSize, object[,] puzzle){
			int init = 1;

			for (int i = 0; i < puzSize; i++) {
				for (int j = 0; j < puzSize; j++) {
				
					puzzle [i, j] = init++;

					if (i + 1 == puzSize && j + 1 == puzSize) {
						puzzle [i, j] = " ";
					}
				}
			}

			return puzzle;
		}

		//Puzzle Start
		public static void startPuzzle(int puzSize, object[,] puzzle){

			string movement;
			Console.WriteLine ("퍼즐을 시작합니다.\n");

			while (true) {
				Console.Write ("W : 위, S : 아래, A : 좌, D : 우 - ");
				movement = Console.ReadLine ();
				moveFragment (puzSize, puzzle, movement);
				viewPuzzle (puzSize, puzzle);
			}
		}

		//View Puzzle
		public static void viewPuzzle(int puzSize, object[,] puzzle){
			for (int i = 0; i < puzSize; i++) {

				Console.Write ("| ");

				for (int j = 0; j < puzSize; j++) {
					Console.Write (puzzle[i,j] + " ");
				}

				Console.WriteLine ("|");
			}
			Console.WriteLine ("");
		}

		//Fragment move
		public static void moveFragment(int puzSize, object[,] puzzle, string movement){

			object teemp;
			int[] temp = new int[2];
			temp = findBlank (puzSize, puzzle); //temp[0] : rawNum, temp[1] colNum

			switch (movement) {
			case "W":
			case "w":
				if (temp [0] == puzSize - 1)
					goto FAIL;

				teemp = puzzle [temp [0], temp [1]];
				puzzle [temp [0], temp [1]] = puzzle [temp [0] + 1, temp [1]];
				puzzle [temp [0] + 1, temp [1]] = teemp;

				break;
			case "S":
			case "s":
				if (temp [0] == 0)
					goto FAIL;

				teemp = puzzle [temp [0], temp [1]];
				puzzle [temp [0], temp [1]] = puzzle [temp [0] - 1, temp [1]];
				puzzle [temp [0] - 1, temp [1]] = teemp;

				break;
			case "A":
			case "a":
				if (temp [1] == puzSize-1)
					goto FAIL;

				teemp = puzzle [temp [0], temp [1]];
				puzzle [temp [0], temp [1]] = puzzle [temp [0], temp [1] + 1];
				puzzle [temp [0], temp [1] + 1] = teemp;

				break;
			case "D":
			case "d":
				if (temp [1] == 0)
					goto FAIL;

				teemp = puzzle [temp [0], temp [1]];
				puzzle [temp [0], temp [1]] = puzzle [temp [0], temp [1] - 1];
				puzzle [temp [0], temp [1] - 1] = teemp;

				break;
			default:
				Console.WriteLine ("W, S, A, D 중의 하나를 선택해주세요.");
				break;
			FAIL:
				Console.WriteLine ("이동할 수 없습니다.");
				break;
			}
		}

		public static int[] findBlank(int puzSize, object[,] puzzle){

			int[] location = new int[2];

			for (int i = 0; i < puzSize; i++) {
				for (int j = 0; j < puzSize; j++) {
					if (puzzle [i, j] == " ") {
						location [0] = i;
						location [1] = j;
						goto END;
					}
				}
			}
			END:
			return location;
		}
	}
}

