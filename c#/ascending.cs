using System;
class ascending
{
	public static void Main()
	{
		int a;
		Console.Write("Enter an integer: ");
		a = Convert.ToInt32(Console.ReadLine());
		
		for(int b=0;b<=a;b++)
		{
			Console.Write(b +"\n");
		}
		Console.Read();
	}
}