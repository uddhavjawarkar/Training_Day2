using System;


namespace Training_Day2
{
    internal class Avg
    {
        public static void Main5()
        {
            int a, b, c, d, e, avg;
            Console.WriteLine("Enter marks of a= ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of b= ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of c = ");
            c=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter marks of d= ");
            d=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of e= ");
            e=Convert.ToInt32(Console.ReadLine());
            avg = (a + b + c + d + e) / 5;
            Console.WriteLine("Avg of 5 sub is = " + (avg));
        }
    }
}
