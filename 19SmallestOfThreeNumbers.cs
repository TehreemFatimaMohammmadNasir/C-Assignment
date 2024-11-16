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
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine()); 

   
        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine("The smallest number is: " + num1);
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine("The smallest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The smallest number is: " + num3);
        }
          
    }
}

