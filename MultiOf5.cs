using System;
//Write a program to display "Hello" if a number entered by user is a multiple of five otherwise print "Bye".

namespace Training_Day2
{
    internal class MultiOf5
    {
        public static void Main8()
        {
            int num;
            Console.Write("Enter Number = ");
            num=Convert.ToInt32(Console.ReadLine());
            {
                if (num % 5 == 0)
                    Console.WriteLine("Hello");
                else
                    Console.WriteLine("Bye");

            }
            
        }
    }
}
