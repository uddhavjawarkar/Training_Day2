using System;


namespace Training_Day2
{
    internal class test3ibm
    {
        public static void Main7()
        {
            int i;
            for (i = -3; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                }
                {
                    if (i > 0)
                        Console.WriteLine("A");
                    else if (i < 0)
                        Console.WriteLine("B");
                }
                Console.ReadLine();
            // Result=B,B,B,ZERO,A,A,A
            }
        }
    }
}
