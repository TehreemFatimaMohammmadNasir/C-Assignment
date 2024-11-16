/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the amount you want to convert: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose the currency you want to convert from (Dollars, Euros, Pounds):");
        string fromCurrency = Console.ReadLine().ToLower();

        Console.WriteLine("Choose the currency you want to convert to (Dollars, Euros, Pounds):");
        string toCurrency = Console.ReadLine().ToLower();

        double convertedAmount = 0;

    
        if (fromCurrency == toCurrency)
        {
            convertedAmount = amount; 
        }
        else
        {
            switch (fromCurrency)
            {
                case "dollars":
                    if (toCurrency == "euros")
                        convertedAmount = amount * 0.93; 
                    else if (toCurrency == "pounds")
                        convertedAmount = amount * 0.82; 
                    break;

                case "euros":
                    if (toCurrency == "dollars")
                        convertedAmount = amount * 1.08; 
                    else if (toCurrency == "pounds")
                        convertedAmount = amount * 0.88; 
                    break;

                case "pounds":
                    if (toCurrency == "dollars")
                        convertedAmount = amount * 1.22; 
                    else if (toCurrency == "euros")
                        convertedAmount = amount * 1.14; 
                    break;

                default:
                    Console.WriteLine("Invalid currency selection.");
                    return;
            }
        }

        // Simplified output line
        Console.WriteLine("Converted amount: " + convertedAmount);
    }
}

