/*using System;

public class Circle{
	private int radius;

    public Circle() : this(1)
    {
	}

    public Circle(int radius){
		this.radius = radius;
	}

	public void DisplayResult(){
		Console.WriteLine($"Area of the circle is {CalcArea()}");
		Console.WriteLine($"Circumference of the circle is {CalcCircum()}");
	}

	public int CalcArea(){
		return (int) (3.14*radius*radius);
	}

	public int CalcCircum(){
		return (int) (2*3.14*radius);
	}

	public static void Main(){
		Console.Write("Enter the Radius : ");
		int radius = Convert.ToInt32(Console.ReadLine());

		Circle c = new Circle(radius);
		c.DisplayResult();

		Console.ReadLine();
	}
}*/