using System;
class Program
{
    static void Main()
    {
        // Ask for the number of arrays (outer array size)
        Console.Write("Enter the number of arrays: ");
        int n = Convert.ToInt32(Console.ReadLine());;

        // Create a jagged array
        string[][] jaggedArray = new string[n][];

        // Loop to fill each inner array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the size of array {i + 1}: ");
            int size = Convert.ToInt32(Console.ReadLine());
            // Initialize the inner array
            jaggedArray[i] = new string[size];

            // Ask for the elements of the inner array
            for (int j = 0; j < size; j++)
            {
                Console.Write("Enter element {j + 1} of array {i + 1}: ");
                jaggedArray[i][j] = Console.ReadLine();
            }
        }

        // Print the elements of the jagged array using foreach loop
        Console.WriteLine("\nArray elements:");
        foreach (var innerArray in jaggedArray)
        {
            foreach (var element in innerArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}