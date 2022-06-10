using System;
//Write a program to input a number and check whether its even or odd.

namespace Training_Day2
{
    internal class CheckEvenOdd
    {
        public static void Main3()
        {start:
            
            int num;
            Console.Write("\nInput a number : ");
            num=Convert.ToInt32(Console.ReadLine());
            {
                if(num%2==0)
                {
                    Console.WriteLine("\nEven No : " + num);
                }
                else
                {
                    Console.WriteLine("\nOdd No : " + num);
                }
            }goto start;
            
               

        }

    }
}
