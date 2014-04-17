using System;

public class NumPuzzle {
	public string name;
	private int [,] mData;
	private int mSize;
	private int xZero, yZero;

	//initialze all.
	public void Init(int size) {
		mSize = size;
		mData = new int[size,size];
		for (int i = 0; i < size; i++)
			for (int j = 0; j < size; j++)
				mData[i,j] = i * size + j + 1;
		mData[size-1,size-1] = 0;
		xZero = yZero = size -1;
	}

	//return all the number sequences
	public string FindMove() {
		string ret = Console.ReadLine ();
		return ret;
	}

	/**
	 * If possible to move, move the number
	 * return true if success, else return false
	 */
	public bool Move(int num) {
		return false;
	}

	private void ZeroLocation() {
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				if (mData[i,j] == 0) {
					xZero = i;
					yZero = j;
					return;
				}
			}
		}
	}

	private bool IsMove(int row, int col) {
		ZeroLocation();
		if (!IsValid(row, col))
			return false;
		if (true){
			//code here

			return true;
		}
	}

	//check whether row and col values are in valid range
	//0 <= row, col < mSize
	private bool IsValid(int row, int col) {
		return ( 0 <= row && 0<= col && row < mSize && col < mSize);
	}

	private void swap(ref int a, ref int b) {
		int temp = a;
		a = b; 
		b = a;
	}

	class Test {
		static void Main() {
			NumPuzzle np = new NumPuzzle();

			//test 1 
			string av = np.FindMove();
			if(av != "6 8") Fail("test 1 fail!!");
			Console.WriteLine("test1 success!");

			//test 2
		}

		static int read(string msg) {
			return 0;
		}

		static void Fail(string msg) {
			Console.WriteLine(msg);
			Environment.Exit(1);
		}
	}
}