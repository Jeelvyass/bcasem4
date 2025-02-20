using System;

class JaggedArray
{
    public static void Main()
    {
        // Get rows from the user
		Console.WriteLine("Enter row number: ");
        int s = Convert.ToInt32(Console.ReadLine()); // number of rows
        
        // Declare a jagged array with `s` rows
        int[][] values = new int[s][];
        
        // Get values for each row (each row can have different columns)
        for (int i = 0; i < s; i++)
        {
            // Get number of columns for this row
            Console.WriteLine("Enter the number of columns for row {0}:", i + 1);
            int f = Convert.ToInt32(Console.ReadLine());
            
            // Create a new array for this row with `f` columns
            values[i] = new int[f];
            
            // Get values for this row
            for (int j = 0; j < f; j++)
            {
                Console.Write("Enter value for index [{0},{1}]: ", i, j);
                values[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Display the entered values
        Console.WriteLine("\nYou entered the values:");
        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < values[i].Length; j++)
            {
                Console.WriteLine("Index [{0},{1}]: {2}", i, j, values[i][j]);
            }
        }

        // Sum of each row
        Console.WriteLine("\nSum of each row:");
        for (int i = 0; i < s; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < values[i].Length; j++)
            {
                rowSum += values[i][j];
            }
            Console.WriteLine("Sum of row {0}: {1}", i + 1, rowSum);
        }
    }
}
