using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Function:-Using parameter & Return type
namespace Training_Day2
{
    internal class Food
    {
        //user defined function
        public string show(string message)
        {
            Console.WriteLine("Inside show function");
            return message;
        }
        //Main function execution entry point of the program
        static void Main(string[] args)
        {
            Food food=new Food();
            string message = food.show("Uddhav Jawarkar");
            Console.WriteLine("Hello "+message);
                
        }
    }
}
