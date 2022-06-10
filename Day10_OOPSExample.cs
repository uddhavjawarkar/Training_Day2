using System;


namespace Training_Day2
{    
    // This is a Class
    internal class Day10_OOPSExample
    {
        // feature
        //int num1=0, num2=0;
        // 1st method
        public static void Main4()
        {
            // oop-Object oriented programming
            // class-group of similar onbjects - Table
            // object- has feature/property & function
            // object feature/property - 4 leg, material - wooden, height
            // function - capacity() - weight hold

            // Example - car
            // feature - color, tyres, weight, model, fuel_type,seater
            // function - speed(), power_window()
            // car objects - Maruti, Audi, Nano, Scorpio

            // int num1, num2; // feature of class
           
            Console.WriteLine("Main method starts");

            // syntax to create an object :- classname objectname = new classname
            Day10_OOPSExample callprint = new Day10_OOPSExample();
            // calling method using project - objectname.methodname();
            callprint.Print(); // non static - create an object & call print
            // static method will call only static method
            readMethod(); //static - allowed

            // syntax - calling a method from different class
            // classname objectname = new classname();
            // new - is a keyword to create an object
            Shapes square = new Shapes();
            square.quad_Area(); // method calling
            Shapes.Print(16); // static method of another class
            square.square_Perimeter(); // method calling
            Console.WriteLine("Main method end");
        }

        // 2nd method - this is used to print the values
        public void Print()
        {
            Console.WriteLine("This is a non Static Print Method");
        }
        // 3rd method - this is used to read value
        public static void readMethod()
        {
            Console.WriteLine("This is a Static Read Method");
        }

    }
    class Shapes
    {
        // rectangle, square, circle, triangle;
        int  area, length = 10, breadth = 12, perimeter;
       
        public void quad_Area()
        {
            // square = side* side
            // rectangle = l*b
            // triangle = 0.5*h*b
            // circle = 3.14 * r*r
            area = length * breadth;
           // Print(area);
            // Console.WriteLine("Area of a Square is " + area);
        }
        public void square_Perimeter()
        {
            // square = side+side
            // rectangle = 2(l+b)
            // triangle = side + side + side
            // circle = 2*3.14*r
            perimeter = length + breadth;
            // Console.WriteLine("Perimeter of a Square is " + perimeter);
           // Print(perimeter);
        }
        public static void Print( int result)
        {
            Console.WriteLine("print method of Shapes class " + result);
            Day10_OOPSExample day10 = new Day10_OOPSExample();  
            day10.Print(); // non static calling
            Day10_OOPSExample.readMethod(); // static calling
        }
    }

}
