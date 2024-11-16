/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter your weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("Enter your height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

           
            double bmi = weight / (height * height);
            Console.WriteLine("BMI: " + bmi);

          
            int category = (int)(bmi / 5);  

          
            switch (category)
            {
                case 0:
                case 1:
                    Console.WriteLine("Underweight");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Normal weight");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Overweight");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Obesity");
                    break;
                default:
                    Console.WriteLine("Invalid BMI category.");
                    break;
            }

            Console.ReadKey();
        }
    }
}

        