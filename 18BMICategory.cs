/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kilograms");
            double weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your height in meters");
            double height = Convert.ToSingle(Console.ReadLine());

           
             double bmi = weight / (height * height);



           
            if (bmi < 18.5)
            {
                Console.WriteLine("You are Underweight");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You are  Normal");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are Overweight");
            }
            else
            {
                Console.WriteLine("You are  Obese");
            }

           
        }
    }
}

