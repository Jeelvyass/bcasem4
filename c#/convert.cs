using System;
class convert
{
	public static void Main()
	{
		int a;
		Console.Write("Enter an integer: ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("You entered: " + a);

		double b;
		Console.Write("Enter an double value: ");
		b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("You entered: " + b);
		
	}
}
