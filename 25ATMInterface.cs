/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class ATMProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ATM!");

        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");

        Console.WriteLine("Enter option ");
        int option = Convert.ToInt32(Console.ReadLine()); 
        decimal balance = 5000.00m; 

        switch (option)
        {
            case 1:
                Console.WriteLine("Your current balance is " + balance);
                break;

            case 2:
                Console.WriteLine("Enter amount to deposit: ");
                balance += Convert.ToDecimal(Console.ReadLine()); 
                Console.WriteLine("New balance: " + balance);
                break;

            case 3:
                Console.WriteLine("Enter amount to withdraw: ");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());  
                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount; 
                    Console.WriteLine("New balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
                break;

            case 4:
                Console.WriteLine("Thank you for using the ATM.");
                break;

           
        } 

    } 
}


