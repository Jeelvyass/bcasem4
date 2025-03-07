using System;
abstract class person
{
	public abstract void fun();
	public void display ()
	{
		Console.WriteLine("display called");
	}
}
class xyz: person
{
	public override void fun()
	{
		Console.WriteLine("fun called");
	}
}
class main_cls
{
	public static void Main()
	{
		xyz obj=new xyz();
		obj.display();
		obj.fun();
	}
}