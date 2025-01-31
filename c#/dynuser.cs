using System;
namespace program
{
	class dynuser
	{
		public static void Main()
		{
			dynamic msg="hello";
			Console.Write("your message is: "+msg +"\n");
			msg = Console.ReadLine();
			Console.Write("you entered:" +msg +"\n");
			Console.Read();
		}
	}
}