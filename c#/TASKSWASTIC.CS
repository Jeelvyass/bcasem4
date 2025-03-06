using System;
class task
{
	public static void Main()
	{
		Console.WriteLine("enter a value: ");
		int n=Convert.ToInt32(Console.ReadLine());
		if(n%2==0)
		{
			Console.WriteLine("enter a odd number: ");

		}
		for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
				if ((i==0 && j>=n/2) || (i==n-1 && j<=n/2) || ( j==0&& i<=n/2) 
				||(i>=n/2 && j==n-1) ||(i==n/2) ||(j==n/2))
                {
                    Console.Write("* "); // Use Console.Write to avoid new lines
                }
                else
                {
                    Console.Write("  "); // Use Console.Write for spaces
                }
            }
            Console.WriteLine(); // Move to the next line after finishing a row
        }
        
        Console.ReadLine();
    }
}



