using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    //program for hotel order
    class OrderItem
    {
        string itemname;
        int qty;
        int price;
    }
     class Bill
    {
         static  int GetPrice(string itemname,Hashtable ht)
        {
            int price = 0;
            foreach(DictionaryEntry d in ht)
            {
                Hashtable submenu=(Hashtable)d.Value;
                if (submenu.ContainsKey(itemname))
                {
                    price=(int)submenu[itemname];
                    break;
                }
            }return price;
        }
        
        static void Main(string[] args)
        {
            Hashtable beverages=new Hashtable();
            beverages.Add("coffee", 50);
            beverages.Add("tea", 50);
            beverages.Add("coldcoffee", 100);
            beverages.Add("Orange Juice", 150);

            Hashtable snacks=new Hashtable();
            snacks.Add("vadapav", 20);
            snacks.Add("samosa", 40);
            snacks.Add("Uttapa", 80);
            snacks.Add("pizza", 150);
            snacks.Add("burger", 250);

            Hashtable menu=new Hashtable();
            menu.Add("Snacks", snacks);
            menu.Add("Beverages",beverages);
            foreach (DictionaryEntry menuitem in menu)
            {
                Console.WriteLine(menuitem.Key);

                Hashtable ht = (Hashtable)menuitem.Value;
                foreach (DictionaryEntry submenu in ht)
                {
                    Console.WriteLine(submenu.Key + "===> RS" + submenu.Value);
                }
                Console.WriteLine("--------------------------------------");
            }
            Hashtable orderlist=new Hashtable();
            do
            {
                Console.WriteLine("Enter item from menu u want to order");
                string item = Console.ReadLine().ToLower();
                Console.Write("Enter Qty: ");
                int qty = int.Parse(Console.ReadLine());
                orderlist.Add(item, qty);
                Console.Write("Do u want to add one more item in ur order yes/no : ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "no")
                    break;

            }
            while (true);
            Console.WriteLine("=======================");
            Console.WriteLine("Order Details");
            int total = 0;
            Console.WriteLine("Menu \t Qty \t Price \t Amt");
            //logic for billing
            foreach(DictionaryEntry d in orderlist) 
            {
                string itemname=(string)d.Key;  
                int qty = (int)d.Value;
                int price = GetPrice(itemname, menu);
                Console.WriteLine(itemname+"\t"+qty+"\t"+price+"\t"+qty*price);
                total = total + (qty * price);
                   
            }
            Console.Write("Total Bill Amt is: "+total);

        }
    }
}
