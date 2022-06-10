using System;
namespace Training_Day2
{
    //
    internal class EvenOdd
    {
        public static void Main3()
        {
            int num1;
            Console.WriteLine("Enter no= ");
            num1=Convert.ToInt32(Console.ReadLine());
            {
                if (num1 % 2 == 0)
                    Console.WriteLine("Even No = " + (num1));
                else
                    Console.WriteLine("Odd No = "+ (num1));

            }
        }
    }
}
