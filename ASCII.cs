using System;
//C# Program to Print ASCII Value.
namespace Training_Day2
{
    internal class ASCII
    {
        public static void Main2()
        {
            char c;
            Console.Write("Enter Character : ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII Value of " + c + " " + Convert.ToInt32(c));
            Console.ReadKey();

        }
    }
}
