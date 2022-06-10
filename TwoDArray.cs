using System;

namespace Training_Day2
{
    internal class TwoDArray
    {
        public static void Main6()
        {
            // Array is a collection of elements
            //Types of arrays are-1D,2D,3D.......nD
            // Syntax=datatype[] arrayname=new datatype[]--1D Array
            // Syntax= datatype[][] arrayname= new datatype[3][4]----[3]row[4]col
            /* 1 2 3 4
               1 2 3 4
               1 2 3 4 */
            // value assign
            //1D marks[]=100
            // 2D Array size = col*row

            int[,] arr = new int[2, 3]; // row=2, col=3
            arr[0, 0] = 11;
            arr[1, 0] = 5;
            arr[1, 1] = 6;
            arr[0, 2] = 13;
            arr[0, 1] = 12;
            arr[1, 2] = 7;
            Console.WriteLine(arr[0, 0]);
            foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }
        }
    }
}

            






 
    