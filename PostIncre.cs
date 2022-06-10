using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class PostIncre
    {
        public static void Main5()
        {
            int num1,result;
                Console.Write("Enter no : ");
            num1=Convert.ToInt32(Console.ReadLine());
                result = num1++;
            Console.WriteLine("Pre Increment no : \n num1 is {0}, result is {1}",num1,result);
       
        }
    }
}
