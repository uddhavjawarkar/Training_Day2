using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program on Out Parameter
namespace Training_Day2
{
    internal class OutPar
    {
        public void show(int a, int b)
        {
            int square = 5;
            a = square;
            b = square;
            //Manipulating value
            a *= a;
            b *= b;
        }//Main function execution entry point of the program

        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            OutPar outPar = new OutPar();//creating object
            Console.WriteLine("Value before passing \n val1= "+val1+"\n val2= "+val2);
            outPar.show( val1,  val2);// passing out argument 
            Console.WriteLine("value after passing \n val1= "+val1+"\n val2= "+val2);

        }
    }
}
