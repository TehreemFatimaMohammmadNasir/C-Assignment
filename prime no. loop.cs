/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/


using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int div = 0; 

           
            
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        div  = 1; 
                        
                    }
                }

                if ( div  == 0) 
                {
                    Console.WriteLine("Number is Prime.");
                }
                else
                {
                    Console.WriteLine("Number is not Prime.");
                }
            }

          
    }
}
