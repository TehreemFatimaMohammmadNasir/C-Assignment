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

   
        int result = num1.average(500,600,1000,1500);
        Console.WriteLine(result);

     
    }
    
    
     int average(int a, int b,int c, int d)
    {
        return (a + b + c + d)/4;
    }
}    
    

