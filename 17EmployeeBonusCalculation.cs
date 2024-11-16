/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class HelloWorld
{
    static void Main()
    {
            Console.WriteLine("Enter the employee's name: ");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Enter years of service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

          
          
            if (yearsOfService >= 5)
            {
                double bonus = salary * 0.10; 
                 Console.WriteLine("Bonus is "+"  "+bonus);
            }
     
            else
            {
                double bonus = salary * 0.05;
            }
    }
    
}