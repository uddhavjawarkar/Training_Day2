using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class Egwhile1
    {
        public static void Main2()
        {
            
            {
                int counter = 0;
                while (counter < 10 && counter % 2 == 0)
                {
                    counter = counter + 2;
                    Console.WriteLine("Even No : " + counter);
                }
                
            }

        }
    }
}
