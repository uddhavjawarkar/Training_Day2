using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    class Statue
    {
        String name;
        ArrayList hobbies = new ArrayList();

        public Statue(string name, ArrayList hobbies)
        {
            this.name = name;
            this.hobbies = hobbies;
        }

        public string Name { get => name; set => name = value; }
        public ArrayList Hobbies { get => hobbies; set => hobbies = value; }
    }
    class zanjir

    {
        static void Main(string[] args)
        {
            ArrayList plist=new ArrayList();
            do
            {
                Console.WriteLine("Enter name");
                String nm=Console.ReadLine();
                Console.WriteLine("Enter no of hobbies u have ");
                int c=int.Parse(Console.ReadLine());


                ArrayList hobbieslist=new ArrayList();
                for(int i=1;i<=c;i++)
                {
                    Console.WriteLine($"{nm} Enter ur hobby ");
                    string h=Console.ReadLine();    
                    hobbieslist.Add(h);

                }
                Statue s=new Statue(nm, hobbieslist);   
                plist.Add(s);
                Console.WriteLine("Do u want to add one more person object yes/no");
                string choice = Console.ReadLine().ToLower();
                if(choice == "no")
                {
                    break;
                }
            }
            while(true);
        }
    }
}
