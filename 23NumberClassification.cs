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
        Console.WriteLine("Enter number");
        int whole = Convert.ToInt32(Console.ReadLine());

        if ( whole  > 0)
        {
            if ( whole  % 2 == 0)
            {
                Console.WriteLine("The number is positive and even.");
            }
            else
            {
                Console.WriteLine("The number is positive and odd");
            }
        }
        else if ( whole  < 0)
        {
            if ( whole  % 2 == 0)
            {
                Console.WriteLine("The number is negative and even");
            }
            else
            {
                Console.WriteLine("The number is negative and odd");
            }
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}


