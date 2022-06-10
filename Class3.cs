using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class Test
    {
        int x = 10;
        static int y = 20;

        static void Main(string[] args)
        {
            int x = 100; int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(Test.y);
          //outp0t=100.200.20
        }
    }
}
