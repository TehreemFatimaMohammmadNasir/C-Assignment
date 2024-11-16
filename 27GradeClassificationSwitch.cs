/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {

        Console.WriteLine("Enter the score");
        int score = Convert.ToInt32(Console.ReadLine());
        
         Console.WriteLine("Enter grade ");
        char grade = Convert.ToChar(Console.ReadLine());
        
        switch (score / 10)
        {
            case 10:
            case 9:
                grade = 'A';
                break;
            case 8:
                grade = 'B';
                break;
            case 7:
                grade = 'C';
                break;
            case 6:
                grade = 'D';
                break;
           
        }

        Console.WriteLine("Grade: " + grade);
  }
}