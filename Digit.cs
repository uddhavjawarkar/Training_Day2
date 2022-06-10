using System;
/*Write a program to input a number and compare whether that number is single digit or
double digit.*/

namespace Training_Day2
{
    internal class Digit
    {
        public static void Main9()
        {
            int a;
            Console.WriteLine("Enter No : ");
            a=Convert.ToInt32(Console.ReadLine());
            {
                if(a>0 && a<9)
                {
                    Console.WriteLine("Single Digit No ");
                }
                else if(a>10 && a<99)
                {
                    Console.WriteLine("Two Digit No ");
                }
                else if(a>100 && a<999)
                {
                    Console.WriteLine("Three Digit No ");

                }
                else if(a>1000 && a<9999)
                {
                    Console.WriteLine("Four Digit No ");
                }
                else if(a>10000 && a<99999)
                {
                    Console.WriteLine("Five Digit No ");
                }
            }
           
        }
    }
}
