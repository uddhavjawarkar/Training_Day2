using System;
namespace Training_Day2
{
    internal class CheckLeapYr
    {
        public static void Main2()
        {
            int chk_year;
            Console.WriteLine("Enter year = ");
            chk_year =Convert.ToInt32(Console.ReadLine());

            {
                if (chk_year % 400 == 0)
                    Console.WriteLine("This is Leap year = "+ chk_year);
                else if(chk_year % 4 == 0)
                    Console.WriteLine("This is Leap year = "+ chk_year);
                else if(chk_year%100 == 0)
                    Console.WriteLine("This is not Leap year = " + chk_year);
                else 
                    Console.WriteLine("This is not Leap year = "+ chk_year);

            }
        }

    }
}
