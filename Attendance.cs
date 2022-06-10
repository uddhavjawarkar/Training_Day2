using System;
/* Accept the following from the user and calculate the percentage of class attended:
a.     Total number of working days
b.     Total number of days for absent
    After calculating percentage show that, If the percentage is less than 75, than student will not be able to sit in exam.*/

namespace Training_Day2
{
    internal class Attendance
    {
        public static void Main7()
        {
            int work, absent, percentage;
            Console.Write("No of Working days : ");
            work = Convert.ToInt32(Console.ReadLine());
            Console.Write("No of Absent days : ");
            absent = Convert.ToInt32(Console.ReadLine());
            {
                percentage = ((work / absent)*100);
                {
                    if (percentage >= 75)
                    
                        Console.WriteLine("Not able to sit for exam ");
                    
                    else
                    
                        Console.WriteLine("Able to sit for exam ");
                    
                }

            }
        }
    }
}

