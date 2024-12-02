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

   
        int result = num1.add(100, 400);
        Console.WriteLine(result);

     
    }
    
    
     int add(int a, int b)
    {
        return a + b;
    }
}    
    

