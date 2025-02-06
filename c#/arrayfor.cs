using System;
class arrayfor
{
	public static void Main()
	{
		int[] a={12,13,14};
		
		for(int i=0;i<3;i++)
		{
			Console.WriteLine("a {0}:{1}", i+1,a[i]);
		}
	}
}