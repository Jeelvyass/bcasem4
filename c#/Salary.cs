using System;
class Salary
{ 
    public void Calculation(ref int basicsalary, out double grosssalary,out double TA,out double DA, out double HRA, out double PF)
    {
         TA = 0;
		 DA = 0;
		 HRA = 0;
		 PF = 0;

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

        grosssalary = basicsalary + TA + DA + HRA - PF;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Basic Salary: ");
        int basicsalary = Convert.ToInt32(Console.ReadLine()); 
		 double TA, DA , HRA , PF ;
        double grosssalary; // Out variable

        Salary obj = new Salary();

        obj.Calculation(ref basicsalary, out grosssalary,out TA,out DA, out HRA, out PF);
        Console.WriteLine("\nYou entered Basic Salary: " + basicsalary);
		
			Console.WriteLine("TA: "+TA);
			Console.WriteLine("DA: "+DA);
			Console.WriteLine("HRA: "+HRA);
			Console.WriteLine("PF: "+PF);
        Console.WriteLine("Your Gross Salary is: " + grosssalary);
    }
}
