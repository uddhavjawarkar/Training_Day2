using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program on C# Passing Array to Function Example: Print maximum number
namespace Training_Day2
{
    public class Maxi
    {
        public static void printmax(int[] arr)
        {
            int max = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max No In Array: "+max);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 15, 20, 44, 50, 60 };
            int[] arr2 = { 17, 52, 35 };
            printmax(arr1);
            printmax(arr2); 

        }
    }
}
