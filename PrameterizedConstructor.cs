using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class Employees
    {
        public int id;
        public string name;
        public float salary;
        public Employees(int i,string n,float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }
    }
    class TestEmployees
    {
        public static void Main(string []args)
        {
            Employees e1 = new Employees(101, "Uddhav", 89000f);
            Employees e2 = new Employees(102, "Vishal", 71000f);
            e1.display();
            e2.display();
        }
    }
    
}
