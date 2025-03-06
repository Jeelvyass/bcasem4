using System;
class swastic 
{
	public static void Main()
	{
		//Console.Write("enter value of b: ");
		
		int b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("you entered value of b is:" +b);
		if(b%2==0)
		{
			Console.WriteLine("you entered {0} is not valid \n so we convert into {1} ", b,b-1);
			b--;
		}
		Console.WriteLine("now b is:{0} ",b);

		int mid=(int)(b/2);
		Console.WriteLine("middle number is {0}",mid+1);
		
		for(int i = 0; i < b; i++)
		{
			for(int j = 0; j < b; j++)
			{
				if(
				(i==0&& j>=mid) 
				||(i==mid) 
				|| (j==mid) 
				||(i==b-1&&j<=mid) 
				||(j==0 && i<=mid)
				||(i>=mid && j==b-1)
				)
				{
					Console.Write("* ");
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
		Console.ReadLine();
	}
}