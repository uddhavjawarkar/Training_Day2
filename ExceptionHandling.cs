using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string nm=Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age=int.Parse(Console.ReadLine());

            for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }

        }
    }

    public class ExHandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Age");

            try
            {

                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Name= " + nm + " Age= " + age);
                Console.WriteLine("Character at 5th position in the name is : " + nm[4]);
                try
                {
                    Console.WriteLine("Enter 2 nos: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Division " + a / b);
                }
                catch (DivideByZeroException a)
                {
                    Console.WriteLine(a.Message);
                }


            }
            catch (FormatException ob)
            {
                Console.WriteLine("Age should be numeric");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
        //Exception Propogation
         class ragel
        {
            static void divide(int a, int b)
            {
                Console.WriteLine("Division "+a/b);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Main Starts");
                try
                {
                    divide(10 , 0);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("In Main exception Handled");
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Main Ends");
            }
        }
    class B
    {
        static int divide(int a, int b)
        {
            try
            {
                Console.WriteLine("In division= ");
                return a/b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("In finally");
            }
            return 0;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            int result = divide(10, 2);
            Console.WriteLine("Answer "+result);
            Console.WriteLine("Main Ends");
        }
        /*Output
      Main Starts
      In division=
      In finally
      Answer 5
      Main Ends*/

    }
    //Null Exception error
    class donald
    {
        static int c;
        static string nm;
        static void Main(string[] args)
        {
            Console.WriteLine(c);
            Console.WriteLine(nm.ToLower());
            Student[] sarr = new Student[100];


            //Console.WriteLine(sarr[0].nm);

        }
    }

}
