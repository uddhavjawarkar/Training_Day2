using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class FunctionEgNoParameter
    {
        //User defined function without return type
        public void show() //no parameter
        {
            Console.WriteLine("This is non parameterized Function");
            // No return statement
        }
        //Main function execution entry point of the program
        static void Main(string[] args)
        {
            FunctionEgNoParameter functionEgNoParameter = new FunctionEgNoParameter(); //Creating Object
            functionEgNoParameter.show(); //Calling Function
        }
    }
}
