﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class JaggedDeclaration
    {
        public static void Main()
        {
            int[][] arr = new int[3][]  //declare the array
            {
                new int[]{11,21,56,78},
                new int[]{2,5,6,7,98,5},
                new int[]{2,5}

            };
            //Traverse array elements
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {

                    Console.WriteLine(arr[i][j]+" ");
                }
            }
            Console.WriteLine();


        }
    }
}
