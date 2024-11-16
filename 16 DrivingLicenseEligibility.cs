/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
      Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if (age >= 18)
        {
            Console.WriteLine("Have you passed the driving test? ");
            string test = Console.ReadLine();
            
            if (test == "yes")
            {
                Console.WriteLine("You are eligible for a driving license.");
            }
            else if (test == "no") 
            {
                Console.WriteLine(" you have failed the test.");
            }
            else
            {
                Console.WriteLine("Invalid input for the test result.");
            }
        }
  }
}