/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class YearCheck
{
    static void Main()
    {
        YearCheck leap = new YearCheck();

       
        Console.Write("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        string result = leap.leapYear(year);
        Console.WriteLine(result);
    }

    string leapYear(int year)
    {
        if (year % 4 == 0)
        {
            return year + "is a leap year";
        }
        else
        {
            return year + "is not a leap year";
        }
    }
}

