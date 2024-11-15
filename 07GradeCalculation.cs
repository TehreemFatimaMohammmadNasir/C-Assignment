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
       
        Console.WriteLine("Enter your marks");
        int marks = Convert.ToInt32(Console.ReadLine());

      
        string grade;

        if (marks >= 90)
        {
            grade = "A";
        }
        else if (marks >= 80)
        {
            grade = "B";
        }
        else if (marks >= 70)
        {
            grade = "C";
        }
        else if (marks >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

      
        Console.WriteLine("Your grade is: " + grade);
    }
}


