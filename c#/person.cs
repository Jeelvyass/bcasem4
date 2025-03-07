using system;
class person
{
	public static void display()
	{
		Console.WriteLine("display called");
	}
	public void abc()
	{
		Console.WriteLine("abc called");
		display();
	}
}
class demo
{
	Console.WriteLine("before function calling ");
	person p1=new person();
	p1.abc();
	Console.WriteLine("after function calling");
}