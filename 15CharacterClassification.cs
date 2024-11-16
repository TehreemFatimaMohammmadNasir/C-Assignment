/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
       Console.WriteLine("Enter a character");
        char ch = Convert.ToChar(Console.ReadLine());

        if (char.IsUpper(ch))
        {
            Console.WriteLine("The character is an uppercase letter.");
        }
        else if (char.IsLower(ch))
        {
            Console.WriteLine("The character is a lowercase letter.");
        }
        else if (char.IsDigit(ch))
        {
            Console.WriteLine("The character is a digit.");
        }
        else
        {
            Console.WriteLine("The character is a special character.");
        }
  }
}