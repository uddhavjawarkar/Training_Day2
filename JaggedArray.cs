using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Let's see a simple example of jagged array in C# which declares, initializes and traverse jagged arrays
namespace Training_Day2
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][]; //Declare the Array
            arr[0] = new int[] { 12, 21, 56, 78 }; //initialize the array
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };
            //Traverse the array elements
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
            }
            Console.WriteLine( );
        }
    }
}
