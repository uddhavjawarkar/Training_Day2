﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class program
    {
        public static void Main()
        {
            int i, j, n, p, q;

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { p = 1; q = 0; }
                else
                { p = 0; q = 1; }
                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0}", p);
                    else
                        Console.Write("{0}", q);
                Console.Write("\n");
            }
        }
    }
}
