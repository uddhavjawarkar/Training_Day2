using System;
/*A company decided to give bonus to employee according to following criteria:
    Time period of Service                Bonus
    More than 10 years             10%
    >=6 and <=10                   8%
    Less than 6 years              5%
    Ask user for their salary and years of service and print the net bonus amount.

*/
namespace Training_Day2
{

    internal class Bonus
    {
        public static void Main6()
        {

            double s,y,b;
            Console.Write("Enter salary : ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Service Period : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y > 10)
            {
                b = (0.1* s) + s;
                Console.WriteLine("Bonus for your service is : " + b);
            }
            else if (y >= 6 && y <= 10)
            {
                b = (0.08 * s) + s;
                Console.WriteLine("Bonus for your service is : " + b);
            }
            else if (y < 6)
            {
                b = (0.05* s) + s;
                Console.WriteLine("Bonus for your service is : " + b);
            }




        }

    }
}
