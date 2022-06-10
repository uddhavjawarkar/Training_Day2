using System;


namespace Training_Day2
{
    internal class Age
    {
        public static void Main6()
        {
            int avg;
            Console.WriteLine("Enter age = ");
            avg =Convert.ToInt32(Console.ReadLine());
            {
                if (avg >= 18 && avg <= 24)
                    Console.WriteLine("You are Teenager");
                else
                    Console.WriteLine("You are not Teenager");

            }

        }
           
    }
}
