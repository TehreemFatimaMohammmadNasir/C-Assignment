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
        
        Console.WriteLine("Enter x-coordinate");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y-coordinate");
        int y = Convert.ToInt32(Console.ReadLine());

       
        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant III.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant IV.");
        }
       
        else
        {
            Console.WriteLine("The point is at the origin.");
        }
    }
}


