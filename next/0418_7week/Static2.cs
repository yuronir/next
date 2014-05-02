using System;

namespace next
{
	public class Human{
		public static int no;
		public int id;
		public string name;
		public void setID(){
			id = ++no;
		}
		public Human(string name){
			this.name = name;
		}
		public static void Init(){
			no = 0;
		}
	}

	public class Static2
	{
		public static void Main ()
		{
			Human.Init ();
			Human h1 = new Human("joongil");
			Console.WriteLine (h1.name);
			Console.WriteLine (Human.no);
			h1.setID ();
			Console.WriteLine (h1.id);
		}
	}
}

