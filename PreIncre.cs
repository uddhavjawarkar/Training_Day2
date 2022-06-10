using System;


namespace Training_Day2
{
    internal class PreIncre
    {
        public static void Main9()
        {
            int num1, result;
            Console.Write("Enter no. : ");
            num1=Convert.ToInt32(Console.ReadLine());
            result = ++num1;
            Console.WriteLine("Pre-Increment : \n result is {0},num1 is {0} ", result , num1 );
        }
    }
}
