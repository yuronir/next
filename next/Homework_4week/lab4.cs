using System;

namespace next
{
	class lab4
	{
		public static void Main ()
		{	
			START:

			int getNumber;

			try{
				Console.Write("반복횟수를 입력하세요 : ");
				getNumber = int.Parse(Console.ReadLine ());
			} catch {
				Console.WriteLine ("0보다 큰 정수를 입력해주세요.");
				goto START;
			}
			if (getNumber < 1) {
				Console.WriteLine ("0보다 작거나 같은 수는 입력할 수 없습니다.");
				goto START;
			}

			for (int i = 1; i < getNumber+1; i++) {
				for (int j = 0; j < i; j++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}
	}
}

