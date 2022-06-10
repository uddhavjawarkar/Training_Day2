using System;

namespace Training_Day2
{
    internal class DivisibleOrNot
    {
        public static void Main4()
        {
            int a, b;
            Console.WriteLine("Enter a = ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            b=Convert.ToInt32(Console.ReadLine());
            {
                if (a % b == 0  )
                    Console.WriteLine("A is divisible by B ");
                else
                    Console.WriteLine("A is not divisible by B ");
            }


        }
    }
}
