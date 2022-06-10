using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
4.	Create ArrayList of T20 Players. 

Create a class Player (playerid,Name,Country,team)
e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)
*/

namespace Training_Day2
{
    public class Coll_test4
    {
        static void Main(string[] args)
        {
            Console.Write("enter player id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Player Name: ");
            string playername = Console.ReadLine();
            Console.Write("Enter Player Country: ");
            string Country = Console.ReadLine();
            Console.Write("Enter Team: ");
            string IPLteam = Console.ReadLine();

            player.detail(id, playername, Country, IPLteam);
                
                

        }       
    }
     class player
    {
        public static void detail(int a,string name,string country,string team)
        {
            int id = a;
            string playername = name;
            string Country = country;
            string IPLteam = team;

            ArrayList tm=new ArrayList();
            tm.Add(id);
            tm.Add(playername);
            tm.Add(Country);
            tm.Add(IPLteam);

            Console.WriteLine($"id= "+id+" PlayerName= "+playername+" Country= "+Country+" IPLTeam= "+IPLteam);
            foreach(var s in tm)
            {
                Console.WriteLine(s+" ");
            }
            Console.ReadLine();
        }
    }
}




