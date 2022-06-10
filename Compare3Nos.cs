using System;
//Write a program to input three numbers and compare them

namespace Training_Day2
{
    internal class Compare3Nos
    {
        public static void Main()
        {
            int a, b, c;
            Console.Write("Enter 1st No. : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No. : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd No. : ");
            c = Convert.ToInt32(Console.ReadLine());
            {
                if(a>b && a>c)
                {
                    Console.WriteLine("A is Greater : "+ a);
                }
                else if (b>a && b>c)
                {
                    Console.WriteLine("B is Greater : " + b);
                }
                else
                {
                    Console.WriteLine("C is Greater : " + c);
                }
            }
        }
    }
}
