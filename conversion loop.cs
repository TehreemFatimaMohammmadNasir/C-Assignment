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
        int total = Convert.ToInt32(Console.ReadLine()); 

        for (int i = 1; i <= total; i++) 
        {
            Console.WriteLine("Write any alphabet in lowercase:");
            string input = Console.ReadLine(); 
            string convert = input.ToUpper(); 
            Console.WriteLine("Converted to Uppercase: " + convert);
        }
    }
}

