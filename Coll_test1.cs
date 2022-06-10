using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Assume you have Arraylist  al = new ArrayList ();
         al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
         Write a code to remove duplicate elements from above list. 
         Final Arraylist should contain ( Sun, Mon, Sat); 
*/

namespace Training_Day2
{
    public class Coll_test1
    {
        static void Main(string[] args)
        {
            ArrayList us = new ArrayList();
            
            us.Add("Sun ");
            us.Add("Mon ");
            us.Add("Sat ");
            us.Add("Sun ");
            us.Add("Mon ");
            us.Add("Sat ");
            us.Add("Sun ");
            us.Add("Sat ");
            us.Add("Sun ");
            us.Add("Mon ");
            
            Console.WriteLine("Capacity: "+us.Count);
            Console.WriteLine("Original arraylist: ");
            foreach (string obj in us)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("--------------------------------------");
            
            Console.WriteLine("After removing duplicates from arraylist: ");

            /*us.RemoveRange(3, 7);
            for (int i=0;i<us.Count;i++)
            {
                for(int j=i+1;j<=us.Count;j++)
                {
                    if (us[i].ToString() == us[j].ToString())
                    {
                        us.RemoveAt(i);
                        Console.Write(us[i]+" ");
                    }
                        
                    
                }
                Console.ReadLine();
                
            }
               */
        }
    }
}
