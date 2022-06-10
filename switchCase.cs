using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class switchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 10:
                    {
                        Console.WriteLine("It is 10");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("It is 20");
                        break;
                    }
                case 30:
                    {
                        Console.WriteLine("It is 30");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Not 10,20,30");
                        break;
                    }
            }
        }
    }
}
