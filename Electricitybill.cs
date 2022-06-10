using System;
/*Write a program to calculate the electricity bill (accept number of unit from user) according to the following criteria :
             Unit                                                     Price  
First 100 units                                               no charge
Next 100 units                                              Rs 5 per unit
After 200 units                                             Rs 10 per unit
(For example if input unit is 350 than total bill amount is Rs2000)
*/

namespace Training_Day2
{
    internal class Electricitybill
    {
        public static void Main4()
        {
            int unit,a,b,c;
            Console.WriteLine("Enter units = ");
            unit=Convert.ToInt32(Console.ReadLine());
            {

                if (unit < 100)
                {
                    a = unit * 0;
                    Console.WriteLine("No charge");
                }

                else if (unit >= 100 && unit < 200)
                {
                    b = ((unit - 100) * 5);
                    Console.WriteLine("The bill is = " + b);
                }
                
                if(unit >= 200)
                {
                    a = (unit - 200);
                    b = (unit - a);
                    c = (b - 100);
                    Console.WriteLine("The bill is = " +(a*10+c*5));
                }
                
                    
                

                    
                       


            }
        }

        
    }
}
