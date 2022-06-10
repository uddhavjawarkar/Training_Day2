using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Sort Arraylist of String in reverse order of its natural sorting
namespace Training_Day2
{
    public class Coll_test2
    {
      

        static void Main(string[] args)
        {
            ArrayList dl = new ArrayList();

            dl.Add("Pune");
            dl.Add("Beed");
            dl.Add("Mumbai");
            dl.Add("Akola");
            dl.Add("Buldhana");

            dl.Sort();
            /*foreach (string s in dl)
            {
                Console.WriteLine(s);
            }*/
            string reverse = " ";


            for (int j = dl.Count-1 ; j >= 0; j--) ;
            {
                //reverse = reverse + dl[j];
            }
            Console.WriteLine(reverse);
           
        }
    }
}
