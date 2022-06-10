using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
9.	and DivideByZeroException.
*/
namespace Training_Day2
{
    internal class Coll_test8
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("To divide no should be greater than 0: Eg ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            string str = "Uddhav";
            try
            {
                Console.WriteLine(str[7]);
            }
            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine(a.Message);
            }








        }
    }
}
