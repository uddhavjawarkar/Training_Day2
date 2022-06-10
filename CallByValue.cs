using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program on Call By Value
namespace Training_Day2
{
    internal class CallByValue
    {
        //User defined function
        public void show(int val)
        {
            val *= val; //Manipulating value
            Console.WriteLine("Value inside the show function= "+val);
            //No return statement

        }
        //Main function execution, entry point of the program
        static void Main(string[] args)
        {
            int val = 50;
            CallByValue value = new CallByValue(); //creating object
            Console.WriteLine("Value before calling the function= " + val);
            value.show(val); //calling function by passing value
            Console.WriteLine("value after calling the function= "+val);
        }
    }
}
