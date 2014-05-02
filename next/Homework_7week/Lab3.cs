using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace next
{
	public class Student{
		public static int total = 0;
		public string name;

		public Student(string name){
			this.name = name;
		}
	}

	public class Lab3
	{
		public static void Main ()
		{
			Student[] stdList = new Student[10];
			List<int> ll = new List<int>();
			Random rd = new Random ();
			int ran;

			//학생 리스트 입력
			while (true) {
				String name = Console.ReadLine ();

				if (name == "qqq") {
					if (Student.total == 0) {
						Console.WriteLine ("최소 한 명을 입력해주세요.");
						continue;
					} else {
						break;
					}
				}
				else {
					//사이즈 초과 시 사이즈 두 배로 늘려기
					if (Student.total == stdList.Length)
						Array.Resize (ref stdList, stdList.Length * 2);
					stdList [Student.total] = new Student (name);
					ll.Add (Student.total);
					Student.total++;
				}
			}

			//선택할 인원수 입력
			GETCOUNT:
			int count = 0;
			Console.Write ("몇 명을 선택하시겠습니까?(1~{0}) : ", Student.total);
			try {
				count = int.Parse (Console.ReadLine ());
			} catch {
				Console.WriteLine ("1명 이상을 선택해주세요.");
				goto GETCOUNT;
			}

			if (count > Student.total || count < 1) {
				Console.WriteLine ("범위를 벗어났습니다.");
				goto GETCOUNT;
			}

			//당첨자 출력
			for (int i = Student.total-1; i >= 0; i--) {
				ran = rd.Next (0, i);
				swap (ll, i, ran);
			}

			for (int i = 0; i < count; i++) {
				Console.Write ("{0}", stdList[ll.ElementAt (i)].name);
				if (i + 1 != count)
					Console.Write (", ");
			}

			Console.WriteLine ("님이 밥을 사시면 되겠습니다. ㅊㅋㅊㅋ!");
		}

		static void swap(List<int> n, int Ran1, int Ran2)
		{
			int v1 = n.ElementAt(Ran1);
			int v2 = n.ElementAt(Ran2);
			n.RemoveAt(Ran1);
			n.Insert(Ran1, v2);
			n.RemoveAt (Ran2);
			n.Insert(Ran2, v1);
		}
	}
}
