using System;

namespace Training_Day2
{
    internal class Vowel
    {
        public static void Main3()
        {
            start:
            char ch;
            Console.WriteLine("Enter any alphabet = ");
            ch=Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a': Console.WriteLine("Vowel");
                    break;
                case 'e': Console.WriteLine("Vowel");
                    break;
                case 'i':Console.WriteLine("Vowel");
                    break;
                case 'o': Console.WriteLine("Vowel");
                    break;
                case 'u': Console.WriteLine("Vowel");
                    break;
                case 'A':
                    Console.WriteLine("Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                    default: Console.WriteLine("Consonant");
                    break;
                    Console.ReadLine();
                     goto start;




            }

        }

    }
}
