using System;


namespace Training_Day2
{
    internal class Triangle
    {
        public static void Main3()
        {
            int a, b, c;
            Console.Write("\n\n");
            Console.Write("Check whether the triangle is Equilateral,Isosceles or Scalene:\n ");
            Console.Write("__________________________________________________________________");
            Console.Write("\n\n");

            Console.WriteLine("Enter Angle a = ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Angle b = ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Angle c = ");
            c=Convert.ToInt32(Console.ReadLine());
            {
                if (a + b + c <= 180)
                    Console.WriteLine("Triangle is valid ");
                {
                    elseif(a==b || b==c);
                    Console.WriteLine("This is Equilateral triangle");
                }
                {
                    elseif(a==b || a==c || b==c);
                    Console.WriteLine("This is Isosceles triangle");
                }
                

                


                    
                           
                 
                   
              


            }
        }

        private static void elseif(bool v)
        {
            throw new NotImplementedException();
        }
        

    }
    

}
