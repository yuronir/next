using System;

public class Dog{
	public static int legs;
	public string name;
	public double weight;
	public bool eatable;
	public static void doubleLeg(){
		legs *= 2;
	}
	public void feed(){
		weight += 0.5;
	}
}

class Test{
	public static void Main(string[] args){
		Dog d1, d2;
		d1 = new Dog ();
		d2 = new Dog ();
		d1.name = "Jico";
		d2.name = "Woo";
		d1.weight = 4.0;
		d2.weight = 10;
		Console.WriteLine (d2.name);
		d1.feed ();
		Console.WriteLine (d1.weight);
	}
}