/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Enter your birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        
        int currentYear = DateTime.Now.Year;

        
        int leapYearCount = 0;

        
        for (int year = birthYear; year <= currentYear; year++)
        {
       
            leapYearCount += Convert.ToInt32(DateTime.IsLeapYear(year)); 
        }

       
       Console.WriteLine("There have been " + leapYearCount + " leap years from " + birthYear + " to " + currentYear);

    }
}
