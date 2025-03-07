using System;
class person 
{
	public void fun()
	{
		Console.WriteLine("fun called");
	}
}
sealed class child:person
{
	public void xyz()
	{
		Console.WriteLine("xyz called");
		
	}
}
class demo
{
	public static void Main()
	{
		child obj=new child();
		obj.xyz();
		obj.fun();
	}
}