using System;

class Operator
{
    
    public static void Main4()
    {
        int num1, num2;
        Console.WriteLine("Enter the 1st no.= ");
        //Variable declaration
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2nd no.= ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //Arithmetic Operators
        //Multiplication
        Console.WriteLine("The multiplication is = " + (num1 * num2));
        //Division
        Console.WriteLine("The quotient is = " + (num1 / num2));
        Console.WriteLine("The remainder is = " + (num1 % num2));
        //Addition
        Console.WriteLine("The addition is = " + (num1 + num2));
        //Substraction
        Console.WriteLine("The Substraction is = " + (num1 - num2));
        
    }

}


