/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Degree Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.WriteLine("3. Fahrenheit to Celsius");
        Console.WriteLine("4. Fahrenheit to Kelvin");
        Console.WriteLine("5. Kelvin to Celsius");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        
        Console.WriteLine("Decide");
        int choose = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Temp");
        int output = Convert.ToInt32(Console.ReadLine());

        int result;

        switch (choose)
        {
            case 1:
                result = (output * 9 / 5) + 32;
                Console.WriteLine(output + " Celsius = " + result + " Fahrenheit");
                break;

            case 2:
                result = output + 273;
                Console.WriteLine(output + " Celsius = " + result + " Kelvin");
                break;

            case 3:
                result = (output - 32) * 5 / 9;
                Console.WriteLine(output + " Fahrenheit = " + result + " Celsius");
                break;

            case 4:
                result = (output - 32) * 5 / 9 + 273;
                Console.WriteLine(output + " Fahrenheit = " + result + " Kelvin");
                break;

            case 5:
                result = output - 273;
                Console.WriteLine(output + " Kelvin = " + result + " Celsius");
                break;

            case 6:
                result = (output - 273) * 9 / 5 + 32;
                Console.WriteLine(output + " Kelvin = " + result + " Fahrenheit");
                break;

           
        }
    }
}

