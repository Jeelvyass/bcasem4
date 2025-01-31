using System;
namespace program
{
	class dyn
	{
		public static void Main()
		{
			dynamic a;
			a = Console.ReadLine();
			Console.Write("you entered: "+a +"\n");
			
			a=Convert.ToInt32(Console.ReadLine());
			Console.Write("it will convert into int: "+a);
			
			Console.Read();
		}
	}
}