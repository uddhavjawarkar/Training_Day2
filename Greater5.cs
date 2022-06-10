using System;
//Write a program to input a number and check whether it is greater than 5 or not.

namespace Training_Day2
{
    internal class Greater5
    {
        public static void Main1()
        {start:
            int num;
            Console.Write("Enter Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            {
                if(num>5)
                {
                    Console.WriteLine("Num is greater than 5 : " + num);
                }
                else if(num==5)
                {
                    Console.WriteLine("Num is same : "+ num);
                }
                else
                {
                    Console.WriteLine("Num is less than 5 : "+ num);
                }
            }goto start;


        }
    }
}
