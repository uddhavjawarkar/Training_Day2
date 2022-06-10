using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program on Passing Array to function:- Print Minimum Number
namespace Training_Day2
{
    internal class mini
    {
        static void PrintMin(int[] arr)
        {
            int min=arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min Element is: "+min);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            int[] arr2 = { 12, 23, 44, 11, 54 };
            PrintMin(arr1);
            PrintMin(arr2);
        }
    }
}
