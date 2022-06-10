using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Day2;

namespace Training_Day2
{
    class Stud
    {
        int sid;
        string nm;

        public Stud(int sid, string nm)
        {
            this.sid = sid;
            this.nm = nm;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Nm { get => nm; set => nm = value; }
    }
    public class HashtableEx
    {


        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Ketaki", 90);
            ht.Add("Sonam", 90);
            // ht.Add(23, alue);
            //
            //ht.Add(new Stud(1, "Priya", "priya@gmail.com"));

            Console.WriteLine(ht[23]);
            ht["Sonam"] = 95;
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "=>" + d.Value);
            }

        }


    }
}


