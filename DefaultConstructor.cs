using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program on Default Constructor
namespace Training_Day2
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default constructor invoked");
        }
    }
    class TestEmployee
    {
       static void Main(string[] args)
       {
            Employee s1 = new Employee();
            Employee s2 = new Employee();
       }
    }
    
}
