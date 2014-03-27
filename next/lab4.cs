using System;

namespace next
{
	public class Circle{
		public int x, y;
		public double r;

		public Circle(){}
		public Circle(int x,int y, double r){
			this.x = x;
			this.y = y;
			this.r = r;
		}
	}

	class Lab4
	{
		//메인함수
		public static void Main ()
		{
			Console.Title = "이용은 lab4 과제";;

			Circle[] circle = new Circle[2];
			circle [0] = new Circle ();
			circle [1] = new Circle ();

			//두 원의 정보 입력
			START:
			for (int i = 0; i < circle.Length; i++) {
				insertData (i, circle[i]);
			}

			//두 원의 충돌여부 확인
			checkSmash (circle);

			Q:
			Console.Write("다시 하시겠습니까? Y/N : ");
			String re = Console.ReadLine();
			if (re != "Y" && re != "N" && re != "y" && re != "n") {
				Console.WriteLine ("Y나 N으로 응답해주세요.");
				goto Q;
			} else if (re == "Y" || re == "y") {
				//다시 시작
				Console.Clear();
				goto START;
			} else if (re == "N" || re == "n") {
				//끝
			}
		}

		//원의 정보 입력
		public static void insertData(int i, Circle circle){
			Console.WriteLine ("{0}번째 원의 정보입니다.", i+1);
		X:	Console.Write ("X좌표 : ");
			try{
				circle.x = Convert.ToInt32(Console.ReadLine ());
			} catch {
				Console.WriteLine ("정수를 입력해주세요.");
				goto X;
			}
		Y:	Console.Write ("Y좌표 : ");
			try{
				circle.y = Convert.ToInt32(Console.ReadLine ());
			} catch {
				Console.WriteLine ("정수를 입력해주세요.");
				goto Y;
			}
		R:	Console.Write ("반지름 : ");
			try{
				circle.r = Convert.ToDouble(Console.ReadLine ());
				if(circle.r <= 0){
					Console.WriteLine("반지름은 0보다 커야 합니다.");
					goto R;
				}
			} catch {
				Console.WriteLine ("숫자를 입력해주세요.");
				goto R;
			}
			Console.WriteLine ("");
		}

		//두 원이 충돌하는지 확인
		public static void checkSmash(Circle[] c){

			int distanceX = c [0].x - c [1].x;
			int distanceY = c [0].y - c [1].y;
			//두 원의 반지름의 합
			double sumRadius = c [0].r + c [1].r; 
			//두 원의 거리
			double distance = Math.Sqrt(distanceX*distanceX + distanceY*distanceY); //

			Console.WriteLine ("두 원의 반지름의 합 : {0}", sumRadius);
			Console.WriteLine ("두 원의 거리 : {0}", distance);

			if(sumRadius < distance){ //두 원이 만나지 않으면
				Console.WriteLine("두 원은 충돌하지 않습니다.");
			} else if(sumRadius == distance) {
				Console.WriteLine("두 원은 닿아있습니다.");
			} else {
				Console.WriteLine("두 원은 충돌합니다!");
			}
		}
	}
}


