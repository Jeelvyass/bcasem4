using System;

class Array2D
{
    public static void Main()
    {
        // Get rows and columns from the user
        int s = Convert.ToInt32(Console.ReadLine()); // number of rows
        int f = Convert.ToInt32(Console.ReadLine()); // number of columns
        
        int[,] values = new int[s, f];

        Console.WriteLine("s: " + s);
        Console.WriteLine("f: " + f);

        // get value from user
        for (int i = 0; i < values.GetLength(0); i++)
        {
            for (int j = 0; j < values.GetLength(1); j++)
            {
                Console.Write("Enter value for index [{0},{1}]: ",i,j);
                values[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Display the entered values
        Console.WriteLine("\nYou entered the values:");
        for (int i = 0; i < values.GetLength(0); i++)
        {
            for (int j = 0; j < values.GetLength(1); j++)
            {
                Console.WriteLine("Index [{0},{1}]: {2}",i,j,values[i,j]);
            }
        }

        // Sum of each row
        Console.WriteLine("\nSum of each row:");
        for (int i = 0; i < s; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < f; j++)
            {
                rowSum += values[i, j];
            }
            Console.WriteLine("Sum of row {0}: {1}",i+1,rowSum);
        }
    }
}
