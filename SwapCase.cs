using System;

namespace Training_Day2
{
    //C# Program to Swap Values of Two Variables. 
    internal class SwapCase
    {
        public static void Main0()
        {
            int num1, num2, swap;
            Console.Write("\nInput First no: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput Second no: ");
            num2= Convert.ToInt32(Console.ReadLine());
            swap = num1;
            num1 = num2;
            num2= swap;
            Console.WriteLine("\nAfter Swap : ");
            Console.WriteLine("\nFirst no "+ num1);
            Console.WriteLine("\nSecond no " + num2);
            Console.ReadLine();
               
        }
    }
}
