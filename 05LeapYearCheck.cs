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
        Console.WriteLine("choose a year");
        int year = Convert.ToInt32(Console.ReadLine());

       if (year % 4 == 0)
       {
      Console.WriteLine("It's a leap year" +year);

        }
      else
      {
      Console.WriteLine("It's not a leap year" +year);   
      }
    }
}
