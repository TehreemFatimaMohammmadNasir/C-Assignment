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
        Console.WriteLine("Enter an integer: ");
        int count = Convert.ToInt32(Console.ReadLine());
        
       

        switch ( count % 2)
        {
            case 0:
                Console.WriteLine("The number is even.");
                break;
            case 1:
                Console.WriteLine("The number is odd.");
                break;
            
        }
    }
}
