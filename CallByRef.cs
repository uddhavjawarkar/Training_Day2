using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    // Program on Call By Reference
    internal class Reference
    {
        //user defned function 
        public void show(ref int val )
        {
            val *= val; //manipulating value
            Console.WriteLine("value inside the show function= "+val);
            //no return statement

        }
        // Main function execution entry point of the program
        static void Main(string[] args)
        {
            int val = 50;
            Reference reference = new Reference(); //creating value 
            Console.WriteLine("Value before calling the function "+val);
            reference.show(ref val); //calling function for passing referance
            Console.WriteLine("value after calling the function= "+val);
        }
    }
}
