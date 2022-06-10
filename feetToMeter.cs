using System;
// C# Program to convert feet to meter.
namespace Training_Day2
{
    internal class feetToMeter
    {
        public static void Main2()
        {
            double feet, meter;
            Console.WriteLine("Enter Distance in Feet = ");
            feet=Convert.ToInt32(Console.ReadLine());
            {
                meter = feet / 3.2808;
                Console.WriteLine("In meters= " + meter);
            }
        }
    }
}
