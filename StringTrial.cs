using System;


namespace Training_Day2
{
    internal class StringTrial
    {
        public static void Main78()
        {
            string s1 = "Uddhav";
            string s2 = "uddhav";

                s1=s1.ToUpper();
            Console.WriteLine(s1);
            s2= s2.ToUpper();
            Console.WriteLine(s2);
            s1= s1.ToLower();
            Console.WriteLine(s1);
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1.StartsWith("udd"));
            Console.WriteLine(s1.EndsWith("av"));
            Console.WriteLine(s1.IndexOf('a'));
            Console.WriteLine(s1.LastIndexOf('a'));

            string ss1 = "       Uddhav Jawarkar stayes in Pune    ";
            Console.WriteLine(ss1.Trim());
            
            ss1=ss1.Trim();
            Console.WriteLine(ss1);

        }
    }
}
