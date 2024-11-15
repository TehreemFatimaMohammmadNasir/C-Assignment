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
        Console.WriteLine("Enter a whole");
        double whole = Convert.ToDouble(Console.ReadLine());

        if (whole> 0)
        {
            Console.WriteLine("The whole is positive.");
        }
        else if (whole < 0)
        {
            Console.WriteLine("The whole is negative.");
        }
        else
        {
            Console.WriteLine("The wholeis zero.");
        }
    }
}
