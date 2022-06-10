using System;
//Write a program to input a number and check if it’s a multiple of 5.

namespace Training_Day2
{
    internal class Multiple5
    {
        public static void Main6()
        {
            int num;
            Console.Write("Enter any number: ");
            num=Convert.ToInt32(Console.ReadLine());
            {
                if(num%5==0)
                {
                    Console.WriteLine("No. is Multiple of 5 : " + num);
                }
                else
                {
                    Console.WriteLine("No. isn't multiple of 5");
                }
            }
        }
    }
}
