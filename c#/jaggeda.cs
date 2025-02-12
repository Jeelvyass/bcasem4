using System;
class jaggeda
{
	public static void Main()
	{
		//declaration
		int[][]jarr=new int[3][];
		
		//intialization
		jarr[0]=new int[]{1,2};
		jarr[1]=new int[]{3,4,5};
		jarr[2]=new int[]{6,7,8,9};
		
		//iterating the elements
		for(int i=0;i<jarr.Length;i++)
		{
			Console.Write("row" + i + ": ");
			for(int j=0;j< jarr[i].Length;j++)
			{
				Console.Write(jarr[i][j] +" ");
			}
			Console.ReadLine();
		}
	}
}