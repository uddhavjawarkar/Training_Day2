using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program on Object and Class
namespace Training_Day2
{
    public class Student
    {
        int id;
        string name;
        public static void Main(string[]args)
        {
            Student s1 = new Student();
            s1.id = 101;
            s1.name = "Uddhav Jawarkar";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name); 

        }
    }
    //C# Class Example 2: Having Main() in another class
    public class Objectclass
    {
        public int id;
        public String name;
    }
    class TestStudent
    {
        public static void Main(string[] args)
        {
            Objectclass s1=new Objectclass();
            s1.id = 101;
            s1.name = "Sonoo Jaiswal";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);

        }
    }


}

