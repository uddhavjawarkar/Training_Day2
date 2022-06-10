using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Eg of C# Function which prints the Array Elements
namespace Training_Day2
{
    public class ArrayFunction
    {
        static void printArray(int[] arr)
        {
            Console.WriteLine("Printing Array Elements: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            int[] arr2 = { 12, 23, 44, 11, 54 };
            printArray(arr1);
            printArray(arr2);
        }
    }
}
