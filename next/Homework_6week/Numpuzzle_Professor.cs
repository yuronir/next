using System;

namespace next
{
	public class NumPuzzle
	{
		private int[,] mBoard;
		private int mCount;
		private int mSize;        

		public void Init(int size)
		{
			//Implement
			//Init state must not be a clear state...
			mSize = size;
			int num = 0;
			mCount = 0;
			mBoard = new int[size, size]; //size by size
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					mBoard[i, j] = num;
					num++;
				}
			}
		}

		public void Move(int num)
		{
			//implement
			mCount++;  
		}

		public void Print()
		{
			//implement
			for (int i =0 ; i < mSize ; i++)
			{
				for (int j =0; j<mSize ;j++)
				{
					if(mBoard[i,j] != 0)
						Console.Write("{0:00} ", mBoard[i, j]);
					else
						Console.Write("[] ");
				}
				Console.WriteLine();
			}
		}

		public int[] PossibleMove()
		{
			//for test
			int[] possible = new int[4]{1, 2, -1, -1};
			return possible;
		}

		public bool IsClear()
		{
			//for test
			return false;
		}

		public int GetTurn()
		{
			return mCount;
		}
	}

	class Test
	{
		static void Main()
		{
			//init class
			NumPuzzle numPuzzle = new NumPuzzle();
			numPuzzle.Init(4);

			numPuzzle.Print();
			//playing game
			while (!numPuzzle.IsClear()) 
			{
				//display possible movement
				int[] possibleList = numPuzzle.PossibleMove();
				Console.Write("움직일 수 있는 숫자는 ");
				foreach (int num in possibleList)
				{
					if (num != -1)
						Console.Write("{0}, ",num);                    
				}
				Console.WriteLine("입니다.");                
				Console.WriteLine("무엇을 움직이겠습니까?(포기하시려면 -99를 넣으세요.)");

				//input and move 
				int moveNum = int.Parse(Console.ReadLine());
				if (moveNum == -99) break;                
				numPuzzle.Move(moveNum);          
			}

			if (numPuzzle.IsClear())
			{
				Console.WriteLine("축하합니다.");
				Console.WriteLine("당신은 {0}만에 끝내셨습니다.", numPuzzle.GetTurn());
			}
			else
			{
				Console.WriteLine("화이팅 !!!! 힘내라 브라더");
				Console.WriteLine("당신은 {0}턴 동안 플레이하셨습니다.", numPuzzle.GetTurn());
			}
			Console.WriteLine("빠이, 짜이지엔");            
		}
	}
}