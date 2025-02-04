using System;
class unboxingg
{
	public static void Main()
	{
		int num=23; 
		object obj=num; 
		int i=(int)obj;
		Console.WriteLine("num value: " + num);
		Console.WriteLine("obj value: " + obj);
		Console.WriteLine("i value: " + i);
		
		
	}
}