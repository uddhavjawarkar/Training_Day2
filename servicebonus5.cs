using System;

namespace Training_Day2
{
    internal class servicebonus5
    {
        public static void Main8()
        {
            start:
            double y, s, b;
            Console.Write("Enter Service Years : ");
            y=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary : ");
            s=Convert.ToInt32(Console.ReadLine());
            b = (0.05 * s) + s;
            {
                if(y>5)
                {
                    Console.WriteLine("Your bonus for service is: " + b);

                }
                else
                {
                    Console.WriteLine("Your are not eligible for bonus");
                }
                goto start;
            }


        }
    }
}
