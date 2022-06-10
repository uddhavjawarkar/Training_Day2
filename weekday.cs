using System;
//Wap to input & print whether it is weekday or weekend


namespace Training_Day2
{
    internal class weekday
    {
        

        public static void Main3()
        {
        start:
            Console.Write("Enter Day : ");
            string day = Console.ReadLine().ToUpper();
            {
                if (day =="SATURDAY" || day=="SUNDAY")
                {
                    Console.WriteLine("Its Weekend : "+day);
                }
                else if (day == "MONDAY" || day == "TUESDAY" || day == "WEDNESDAY" || day == "THURSDAY" || day == "FRIDAY")
                {
                    Console.WriteLine("Its Weekday : "+day);
                }
                else
                {
                    Console.WriteLine("Invalid Input-Please Try Again");
                }
                goto start;
            }
        }
    }
}
