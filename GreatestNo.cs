using System;
//Write a program to input two numbers and compare them.

namespace Training_Day2
{
    internal class greatestNo
    {
        public static void Main9()
        {
            int a, b;
            Console.Write("Enter No 1 : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No 2 : ");
            b=Convert.ToInt32(Console.ReadLine());
            {
                if(a>b)
                {
                    Console.WriteLine("A is greatest no: " + a);
                }
                else if(b>a)
                {
                    Console.WriteLine("B is greatest no: " + b);
                }
                else
                {
                    Console.WriteLine("A and B are Equal No. :" );
                }
            }
        }
    }
}
