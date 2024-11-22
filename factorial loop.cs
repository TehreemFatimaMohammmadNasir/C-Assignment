/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Factorial of 7 has been calculated");

        int factorial = 1;

        for (int F = 1; F <= 7; F++)
        {
            factorial *= F; 
        }

        Console.WriteLine("FACTORIAL IS: " + factorial);
    }
}
