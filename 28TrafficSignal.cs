/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class TrafficLightInstructions
{
    static void Main()
    {
        Console.WriteLine("Enter the traffic light color (R, Y, G): ");
        string lightColor = Console.ReadLine(); 

        switch (lightColor)
        {
            case "R":
                Console.WriteLine("Hold on until signals turns green.");
                break;

            case "Y":
                Console.WriteLine("Alert! to stop.");
                break;

            case "G":
                Console.WriteLine("Go Ahead.");
                break;

        }
    }
}

