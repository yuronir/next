using System;
namespace next {
	public class Student{
		public String name;
		public double kor;
		public double math;
		public double avg;

		public void getAvg(){
			avg = (kor+math)/2;
		}
	}

	class Test{
		public static void Main(String[] args){

			Console.Title = "이용은 lab3 과제";

			//for student s1
			Student s1 = new Student();
			Student s2 = new Student();
			Student[] ss = new Student[3];
			ss [0] = new Student (); //배열의 각 클래스도 초기화해주어야한다!
			ss [0].name = "abc";

			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			s1.getAvg();
		
			//for Student s2
			s2.name = "Joong";
			s2.kor = 95;
			s2.math = 77;
			s2.getAvg();

			double totalAvg;
			totalAvg = (s1.avg+s2.avg)/2;

			Console.WriteLine("{0}의 평균은 {1}입니다.", s1.name, s1.avg);
			Console.WriteLine("{0}의 평균은 {1}입니다.", s2.name, s2.avg);
			Console.WriteLine("전체 평균은 {0}입니다.", totalAvg);
		}
	}
}
