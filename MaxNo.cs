using System;


namespace Training_Day2
{
    internal class MaxNo
    {
        public static void Main7()
        {
            int a,b;
            Console.WriteLine("Enter no a= ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no b= ");
            b=Convert.ToInt32(Console.ReadLine());
            {
                if (a >= b)
                    Console.WriteLine("A is greater = " + (a));
                else
                    Console.WriteLine("B is greater = " + (b));


            }
        }
    }
}
