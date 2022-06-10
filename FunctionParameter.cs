using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Function :- Using Parameter but no return type.
namespace Training_Day2
{
    internal class FunctionParameter
    {
        // user defined function without return type
        public void show(string message)
        {
            Console.WriteLine("Hello "+message);
            //no return statement
        }
        //Main function execution entry point of the program
        static void Main(string[] args)
        {
            FunctionParameter functionParameter=new FunctionParameter(); // Creating object

            functionParameter.show("Uddhav Jawarkar"); //Calling function
        }
    }
}
