using System;
//C# Program to Calculate Area of Circle.

namespace Training_Day2
{
    internal class AreaOfCircle
    {
        public static void Main3()
        {
            double Radius,Area;
            Console.WriteLine("Enter Radius : ");
            Radius=Convert.ToDouble(Console.ReadLine());
            Area = Math.PI * Radius * Radius;
            Console.WriteLine("Area of Circle is : "+ Area);
        }
    }
}
