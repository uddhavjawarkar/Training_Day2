using System;


namespace Training_Day2
{
     class nestedfor8
    {
        public static void Main7()
        {
            int n;
            Console.Write("Enter no : ");
            n=Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (n = 1; n <= row; n++)
                {
                    Console.Write("8");
                }
            }
            Console.WriteLine("/n");
        }
    }
}
