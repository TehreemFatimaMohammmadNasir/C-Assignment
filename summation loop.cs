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
        Console.WriteLine("Enter a Number to find the summation of all numbers up to it:");
          int range = Convert.ToInt32(Console.ReadLine());
           int sum = 0;
            for (int i = 1; i <= range; i++)
        {
            sum += i; 
        }
              Console.WriteLine("The summation of numbers from 1 to " + range + "is:" + sum);
    }
}
        
      
        
       

 
