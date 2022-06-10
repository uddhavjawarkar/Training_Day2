using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class MockPrimeNo
    {
        public static void Main()
        {
            int num1, i ;
            Console.Write("Enter No : ");
            num1 =Convert.ToInt32(Console.ReadLine());
            bool IsPrime=true;
            for (i = 2; i < num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    IsPrime = false;
                    break;

                }
            }   
             if(IsPrime)
                    { 
                        Console.WriteLine("Prime No:{0} ",num1);
                    }
             else
            {
                Console.WriteLine("Not Prime No : {0}", num1);
            }
            
            
                
                
                        
            

        }
    }
}
