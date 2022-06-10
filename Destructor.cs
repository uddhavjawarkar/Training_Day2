using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("constructor Invoked");
        }
        ~Destructor()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class TestDestructor
    {
        public static void Main()
        {
            Destructor d1= new Destructor();    
            Destructor d2= new Destructor();
        }
    }
}
