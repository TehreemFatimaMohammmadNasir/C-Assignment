/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Operators{
 static void Main()
  {
        Operators num1 = new  Operators();

   
        double result = num1.squareroot(400);
        Console.WriteLine(result);

     
    }
    
    
     double squareroot(double a)
    {
          return Math.Sqrt(a);
    }
}    
    

