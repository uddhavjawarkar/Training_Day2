using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    public class class5
    {
        static void Main(string[] args)
        {
            List<int> al=new List<int>();
            al.Add(20);
            al.Add(90);

            Console.WriteLine(al[0]);

            List<Stud> al2=new List<Stud>();
            //Array hashing
            Dictionary<int,string> d1=new Dictionary<int,string>();
            d1.Add(23, "om");
            d1.Add(8, "Ram");

            Console.WriteLine(d1.ContainsKey(25));
            Console.WriteLine(d1.ContainsValue("Ram"));
            d1[23] = "Ketan";
            d1.Remove(23);

            foreach(KeyValuePair<int,string> k in d1)
                Console.WriteLine(k.Key+"==>"+k.Value);
            foreach(int i in d1.Keys)
            {
                Console.WriteLine(i+"==>"+d1[i]);
            }
        }
    
    }
}
