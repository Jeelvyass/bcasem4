using System;
namespace class1 
{
	class statcon
	{
		static int a;
		static statcon(int x)
		{
			a=x;
			Console.WriteLine("hello world");
		}
		void display()
		{
			Console.WriteLine(a);
		}
		public static void Main()
		{
			statcon p=new statcon(10);
			statcon p1=new statcon(30);
			p.display();
			p1.display();
			
		}
	}
}
