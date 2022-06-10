using System;
// C# Program to convert days to years, weeks and days

namespace Training_Day2
{
    internal class ConvertDays
    {
        public static void Main5()
        {
            int days, weeks, years;
            Console.WriteLine("Enter Days : ");
            days=Convert.ToInt32(Console.ReadLine());
            years = days / 365;
            weeks = (days % 365 )/7 ;
            days = days - (years * 365) + (weeks * 7);
            Console.WriteLine("years = "+ years);
            Console.WriteLine("weeks = " + weeks);
            Console.WriteLine("days = "+ days);
            
            
        }
    }
}
