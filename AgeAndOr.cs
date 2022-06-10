using System;
//Write a program to input age of a person and print if he/she is teenager or not. using AND-OR

namespace Training_Day2
{
    internal class AgeAndOr
    {
        public static void Main7()
        {
            int age;
            Console.WriteLine("Input age of a person : ");
            age =Convert.ToInt32(Console.ReadLine());
            {
                if(age>18 && age<24)
                {
                    Console.WriteLine("Teenager ");
                }
                else if(age<18)
                {
                    Console.WriteLine("Child ");
                }
                else
                {
                    Console.WriteLine("Young Men");
                }
            }
        }
    }
}
