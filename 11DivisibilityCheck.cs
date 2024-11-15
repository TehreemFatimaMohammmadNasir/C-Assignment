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
        Console.Write("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 5 == 0 && number % 11 == 0)
        {
            Console.WriteLine("The number is divisible by both 5 and 11.");
        }
        else
        {
            Console.WriteLine("The number is not divisible by both 5 and 11.");
        }
    }
}
