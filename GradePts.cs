using System;
/*Write a program to accept percentage from the user and display the grade according to the following criteria:

         Marks                                    Grade
         > 90                                         A
         > 80 and <= 90                       B
         >= 60 and <= 80                       C
         below 60                                  D*/
namespace Training_Day2
{
    internal class GradePts
    {
        public static void Main5()
        {
            int marks;
            Console.Write("Enter Marks : ");
            marks=Convert.ToInt32(Console.ReadLine());
            {
                if (marks >= 90)
                {
                    Console.WriteLine("Grade A");
                }
                else if (marks >= 80 && marks <= 90)
                {
                    Console.WriteLine("Grade B");
                }
                else if (marks >= 70 && marks <= 80)
                {
                    Console.WriteLine("Grade C");
                }
                else if (marks >= 60 && marks <= 70)
                {
                    Console.WriteLine("Grade D");

                }
                else
                {
                    Console.WriteLine("Fail");
                }

                                   
            }

        }
    }
}
