/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Enter an integer: ");
     int num = Convert.ToInt32(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even" +num);
        }
        else
        {
            Console.WriteLine("The number is odd" +num);
        }
         
  }
}
