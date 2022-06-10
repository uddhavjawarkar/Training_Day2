using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class Studentclass
    {
        public int id;
        public string name;
        public void insert(int i, string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }
    }

        class SrManager
        {
            public static void Main(string[] args)
            {
                Studentclass s1 = new Studentclass();
                Studentclass s2 = new Studentclass();
                s1.insert(101, "Ajeet");
                s2.insert(102, "Tom");
                s1.display();
                s2.display();
            }
        }
       
}
