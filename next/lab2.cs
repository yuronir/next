using System;

namespace next
{
	class Lab2
	{
		public static void Main ()
		{
			Console.Title = "이용은 lab2 과제";

			double bottom, height, area;
			String name, temp;

			Console.Write("이름? ");
			name = Console.ReadLine();
			
			Console.Write("밑변? ");
			temp = Console.ReadLine();
			bottom = Convert.ToDouble(temp);
			
			Console.Write("높이? ");
			temp = Console.ReadLine();
			height = Convert.ToDouble(temp);

			area = bottom*height/2;
			Console.WriteLine("{0}의 넓이={1}",name,area);
		}
	}
}

