using System;

class Swastik 
{
    public static void Main()
    {
        Console.Write("Enter value of b (must be an odd number): ");
        
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered value of b is: " + b);
        
        // Ensure b is an odd number
        if (b % 2 == 0)
        {
            Console.WriteLine("You entered {0} is not valid. So we convert it into {1}.", b, b - 1);
            b--;
        }
        
        Console.WriteLine("Now b is: {0}", b);
        
        int mid = (int)(b / 2); // mid should be an integer
        Console.WriteLine("Middle index is {0}", mid+1);
        
        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < b; j++)
            {
                // Corrected conditions for drawing the swastika
                if ((i == 0 && j >= mid) || 
                    (i == mid) || 
                    (j == mid) || 
                    (i == b - 1 && j <= mid) || 
                    (j == 0 && i <= mid) || 
                    (i >= mid && j == b - 1))
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


