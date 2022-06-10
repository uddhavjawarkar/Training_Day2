using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    internal class ArrayListCollection
    {
        static void Main(string[] args)
        { 
            ArrayList al = new ArrayList();
            Console.WriteLine("Capacity: "+al.Count);
            al.Add(200);
            al.Add("Omkar");
            al.Add(9.5);
            al.Add(900);
            Console.WriteLine("Capacity: "+al.Count);    
            al.Add(200);
            al.Add(8765);
            al.Insert(1, "Rohit");
            Console.WriteLine("Capacity: "+al.Count);
            al.Remove(200);
            al.Reverse();
            al.Sort();
          






            foreach (var i in al)
                Console.WriteLine(i);
            Console.WriteLine("------------------");

            for(int i=0;i<al.Count;i++)
                Console.WriteLine(al[i]);


        }
    }
}
