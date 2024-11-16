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
    
        Console.WriteLine("Enter the no. of units consumed: ");
        double units = Convert.ToDouble(Console.ReadLine());
        
        double billAmount;

        if (units <= 400)
        {
            billAmount = units * 1.5;
        }
        else if (units <= 500)
        {
            billAmount = 100 * 1.5 + (units - 100) * 2.5;
        }
        else if (units <= 600)
        {
            billAmount = 100 * 1.5 + 100 * 2.5 + (units - 200) * 3.5;
        }
        else
        {
            billAmount = 100 * 1.5 + 100 * 2.5 + 100 * 3.5 + (units - 300) * 5;
        }

        Console.WriteLine("Total bill amount: " + billAmount + " units");
    }
}


