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
        Console.Write("Enter an integer");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.Write("The number is positive");
        }
        else if (number < 0)
        {
            Console.Write("The number is negative");
        }
        else
        {
            Console.Write("The number is zero");
        }
    }
}
