/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a word or number: ");
        string input = Console.ReadLine();

      
        if (input[0] == input[input.Length - 1])
        {
           Console.WriteLine( "is a palindrome." +input);

        }
        else
        {
           Console.WriteLine( "is not a palindrome." +input);

        }
    }
}

        