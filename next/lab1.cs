using System;

namespace next
{
	class MainClass
	{
		public static void Main (String[] args)
		{
			int kor1, kor2;
			int math1, math2;
			double avg1, avg2, avg3;
			String name1, name2, name3;

			Console.Title = "이용은 lab1 과제";
			Console.WriteLine ("====Score====");

			//fix and complete code
			name1 = "임정민";
			name2 = "배철오";
			name3 = "Everyone";
			kor1 = 80; kor2 = 88;
			math1 = 90; math2 = 60;
			avg1 = (kor1 + math1) / 2;
			avg2 = (kor2 + math2) / 2;
			avg3 = (avg1 + avg2) / 2;

			Console.WriteLine ("AVG of {0}: {1}", name1, avg1);
			Console.WriteLine ("AVG of {0}: {1}", name2, avg2);
			Console.WriteLine ("AVG of {0}: {1}", name3, avg3);
		}
	}
}
