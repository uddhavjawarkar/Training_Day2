using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class Students
    {
        public int id, age;
        public string name, subject;

        public Students(int id,string name,int age, string subject)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.subject = subject;
        }
        public void show()
        {
            Console.WriteLine(id+" "+name+" "+age+" "+subject);
        }

    }
    public class StudentDetails
    {
         public static void Main(string[] args)
        {
            Students std1 = new Students(001, "Jack", 23, "Maths");
            Students std2 = new Students(002, "Harry", 24, "Science");
            Students std3 = new Students(003, "Steve", 21, "History");
            Students std4 = new Students(004, "David", 22, "English");
        }
    }
}
