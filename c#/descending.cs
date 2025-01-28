using System;
class descending
{
	public static void Main()
	{
		int c=10;
		int a;
		Console.Write("Enter an integer: ");
		a = Convert.ToInt32(Console.ReadLine());
		while(c>=1)
		{
			 
			Console.Write(c +"\n");
			c--;
		}
		Console.Read();
	}
}