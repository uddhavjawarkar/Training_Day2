using System;


namespace Training_Day2
{
    internal class test5ibm
    {
        public static void Main6()
        {
            int i,j;
            for (i = 1, j = i; i <= 3 && j >= 0; i++, j--) 
            {
                if (i == j)
                    continue;
                else
                    Console.WriteLine(j);

            }
            Console.ReadLine();
        }
    }
}
