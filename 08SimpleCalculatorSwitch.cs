/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class Calculator
{
    static void Main()
    {
        
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

       
        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

      
        Console.WriteLine("Enter the operation (+, -, *, /)");
        char operation = Convert.ToChar(Console.ReadLine());

        
        switch (operation)
        {
            case '+':
                Console.WriteLine("solution: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("solution: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("solution: " + (num1 * num2));
                break;

            case '/':
                {
                    Console.WriteLine("solution: " + (num1 / num2));
                }
               break;

           
        }
    }
}
