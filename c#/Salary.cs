using System;

class Salary
{
    // Method to calculate Gross Salary using ref and out parameters
    public void Calculation(ref double basicsalary, out double grosssalary)
    {
        // Declare and initialize variables
        double TA = 0, DA = 0, HRA = 0, PF = 0;

        // Apply salary conditions
        if (basicsalary >= 35000 && basicsalary <= 45000)
        {
            Console.WriteLine("\nYour basic salary is between 35000 and 45000.");
            TA = (basicsalary * 5.0) / 100;  // 5%
            DA = (basicsalary * 5.0) / 100;  // 5%
            HRA = (basicsalary * 15.0) / 100; // 15%
            PF = (basicsalary * 8.5) / 100;  // 8.5%
        }
        else if (basicsalary < 35000)
        {
            Console.WriteLine("\nYour basic salary is less than 35000.");
            TA = (basicsalary * 9.0) / 100;  // 9%
            DA = (basicsalary * 12.0) / 100; // 12%
            HRA = (basicsalary * 20.0) / 100; // 20%
            PF = (basicsalary * 8.5) / 100;  // 8.5%
        }

        // Calculate Gross Salary
        grosssalary = basicsalary + TA + DA + HRA - PF;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Basic Salary: ");
        double basicsalary = Convert.ToDouble(Console.ReadLine()); 
        double grosssalary; // Out variable

        // Create object of Salary class
        Salary obj = new Salary();

        // Call Calculation method
        obj.Calculation(ref basicsalary, out grosssalary);

        // Print Gross Salary
        Console.WriteLine("\nYou entered Basic Salary: " + basicsalary);
        Console.WriteLine("Your Gross Salary is: " + grosssalary);
    }
}
