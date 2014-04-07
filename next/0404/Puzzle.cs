using System;

namespace next
{
	public class Puzzle
	{
		public static void Main ()
		{
			int puzSize;
			string isRestart;
			string[] answerSet = { "Y", "y", "N", "n" };

			object[,] puzzle;

			while(true){
			
				puzSize = getRangedInteger(2,5,"퍼즐의 크기를 선택해주세요(2~5)");
				Console.WriteLine ("{0} X {0} 퍼즐입니다.", puzSize);

				puzzle = new object[puzSize, puzSize];
				puzzle = initPuzzle (puzSize);

				Console.WriteLine ("퍼즐을 시작합니다.\n");

				viewPuzzle (puzSize, puzzle);
				startPuzzle (puzSize, puzzle);

				isRestart = getChosenString(answerSet, "계속하시겠습니까?");
				if (isRestart == "Y" || isRestart == "y") {
					continue;
				} else {
					break;
				}
			}
		}

		//Reset Puzzle
		public static object[,] initPuzzle(int puzSize){
			return mixPuzzle (puzSize, answerPuzzle(puzSize));
		}

		//Puzzle Start
		public static void startPuzzle(int puzSize, object[,] puzzle){

			int moveCount = 0;
			string movement;
			object[,] ansPuz = answerPuzzle (puzSize);

			Console.WriteLine ("퍼즐을 시작합니다.\n");

			while (true) {
				Console.WriteLine ("이동 횟수 : {0}", moveCount);
				Console.Write ("W : 위, S : 아래, A : 좌, D : 우 - ");

				movement = Console.ReadLine ();
				puzzle = moveFragment (puzSize, puzzle, movement);
				moveCount++;
				viewPuzzle (puzSize, puzzle);

				if (isPuzEqual(puzSize, puzzle, ansPuz)) {
					Console.WriteLine ("퍼즐이 완성되었습니다. 축하드립니다!\n" +
						"이동 횟수 : {0}", moveCount);
					break;
				}
			}
		}

		//퍼즐을 보여주는 함수
		public static void viewPuzzle(int puzSize, object[,] puzzle){
			for (int i = 0; i < puzSize; i++) {

				if (puzzle[i, 0].Equals(" ") || (int) puzzle [i, 0] < 10) {
					Console.Write ("|  ");
				} else {
					Console.Write ("| ");
				}
					
				for (int j = 0; j < puzSize; j++) {
					if (j+1 != puzSize && (puzzle[i, j+1].Equals (" ") || (int) puzzle [i, j + 1] < 10)) {
						Console.Write (puzzle [i, j] + "  ");
					} else {
						Console.Write (puzzle [i, j] + " ");
					}
				}

				Console.WriteLine ("|");
			}
			Console.WriteLine ("");
		}

		//퍼즐을 이동시키는 함수
		public static object[,] moveFragment(int puzSize, object[,] puzzle, string movement){

			Console.Clear ();
			Console.WriteLine ("");

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

			return puzzle;
		}

		//빈칸을 찾는 함수
		public static int[] findBlank(int puzSize, object[,] puzzle){

			int[] location = new int[2];

			for (int i = 0; i < puzSize; i++) {
				for (int j = 0; j < puzSize; j++) {
					if (puzzle [i, j].Equals(" ")) {
						location [0] = i;
						location [1] = j;
						goto END;
					}
				}
			}
			END:
			return location;
		}

		//퍼즐을 섞는 함수
		public static object[,] mixPuzzle(int puzSize, object[,] puzzle){
			Random rd = new Random();
			object teemp;
			int[] temp;
			int mixCount = rd.Next (100, 300);

			for(int i = 0; i < mixCount; i++){
				temp = findBlank (puzSize, puzzle);
				int rdTemp = rd.Next(0, 4);

				switch (rdTemp) {
				case 0:
					if (temp [0] == puzSize - 1)
						goto FAIL;

					teemp = puzzle [temp [0], temp [1]];
					puzzle [temp [0], temp [1]] = puzzle [temp [0] + 1, temp [1]];
					puzzle [temp [0] + 1, temp [1]] = teemp;

					break;
				case 1:
					if (temp [0] == 0)
						goto FAIL;

					teemp = puzzle [temp [0], temp [1]];
					puzzle [temp [0], temp [1]] = puzzle [temp [0] - 1, temp [1]];
					puzzle [temp [0] - 1, temp [1]] = teemp;

					break;
				case 2:
					if (temp [1] == puzSize - 1)
						goto FAIL;

					teemp = puzzle [temp [0], temp [1]];
					puzzle [temp [0], temp [1]] = puzzle [temp [0], temp [1] + 1];
					puzzle [temp [0], temp [1] + 1] = teemp;

					break;
				case 3:
					if (temp [1] == 0)
						goto FAIL;

					teemp = puzzle [temp [0], temp [1]];
					puzzle [temp [0], temp [1]] = puzzle [temp [0], temp [1] - 1];
					puzzle [temp [0], temp [1] - 1] = teemp;

					break;
				
					//if failed move, don't count.
					FAIL: i--;
					break;
				}
			}

			return puzzle;
		}

		public static bool isPuzEqual(int puzSize, object[,] puz1, object[,] puz2){

			bool isEqual = true;

			for(int i = 0; i < puzSize; i++){
				for(int j = 0; j < puzSize; j++){
					if(!puz1[i,j].Equals(puz2[i,j])){
						isEqual = false;
					}
				}
			}

			return isEqual;
		}

		//최초 퍼즐 상태 반환
		public static object[,] answerPuzzle(int puzSize){
			int init = 1;
			object[,] ansPuz = new object[puzSize, puzSize];

			for (int i = 0; i < puzSize; i++) {
				for (int j = 0; j < puzSize; j++) {

					ansPuz [i, j] = init++;

					if (i + 1 == puzSize && j + 1 == puzSize) {
						ansPuz [i, j] = " ";
					}
				}
			}

			return ansPuz;
		}

		//원하는 범위의 정수를 입력받기 위한 함수
		public static int getRangedInteger(int min, int max, String comment){

			int result = -2;

			while (true) {
				Console.Write ("{0} : ", comment);

				try {
					result = int.Parse (Console.ReadLine ());
				} catch {
					Console.WriteLine ("{0}과 {1} 사이의 정수를 선택해주세요.", min, max);
					continue;
				} if (result < min || result > max) {
					Console.WriteLine ("{0}과 {1} 사이의 정수를 선택해주세요.", min, max);
					continue;
				} else {
					break;
				}
			}

			return result;
		}

		//원하는 글자를 입력받기 위한 함수
		public static string getChosenString(string[] stringSet, string comment){

			string result = "";

			while (true) {
				Console.Write ("{0} : ", comment);

				result = Console.ReadLine ();

				for (int i = 0; i < stringSet.Length; i++) {

					if (result == stringSet [i]) {
						return result;
					}
				}

				Console.Write ("다시 입력해주세요.\n 입력할 수 있는 글자 :");

				for (int j = 0; j < stringSet.Length; j++) {
					Console.Write (" {0},", stringSet [j]);
				}

				Console.WriteLine ("");
			}
		}
	}
}

