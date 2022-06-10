using System;
//check whether a number is divisible by 5 and 11 or not
namespace Training_Day2
{
    internal class Divisibleby5
    {
        public static void Main6()
        {
            int num;
            Console.WriteLine("Enter Number = ");
            num=Convert.ToInt32(Console.ReadLine());
            {
                if (num % 5 == 0 || num % 11 == 0)
                    Console.WriteLine("The no is Divisible by 5 & 11 : " + num);
                else
                    Console.WriteLine("The no. is not Divisible by 5 & 11");

                       

            }
        }
     
    }
}
