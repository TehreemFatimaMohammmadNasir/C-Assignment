/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Operators
{
    static void Main()
    {
        Operators num1 = new Operators();

        double result = num1.cubeRoot(8); 
        Console.WriteLine(result); 
    }

    double cubeRoot(double a) 
    {
        return Math.Cbrt(a); 
    }
}


