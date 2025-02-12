using System;
class array2d
{
	public static void Main()
	{
		int s = Convert.ToInt32(Console.ReadLine());
		int f = Convert.ToInt32(Console.ReadLine());
		int[,] values = new int[s,f];
		Console.WriteLine("s:" +s);
		Console.WriteLine("f:" +f);
	 		

		for (int i = 0; i < values.GetLength(0); i++) 
		{ 
			for (int j = 0; j < values.GetLength(1); j++) 
			{ 
			values[i,j]=Convert.ToInt32(Console.ReadLine());
			} 
		} 
		
		Console.WriteLine("you enterd a value is: \n"); 
		for (int i = 0; i < values.GetLength(0); i++) 
		{ 
			for (int j = 0; j < values.GetLength(1); j++) 
			{ 
			
				Console.WriteLine("index {0} {1}:  {2} ",i,j,values[i, j]); 
			} 
		} 
	}
}
