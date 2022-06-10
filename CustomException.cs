using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(string msg):base(msg)
        {

        }
    }
    class User
    {
        string name;
        long mobile;
        string password;

        public void accept()
        {
            Console.WriteLine("Enter name,mobile,password");
            name = Console.ReadLine();
            mobile = long.Parse(Console.ReadLine());
            password = Console.ReadLine();
            validate();

            void validate()
            {
                //name only alphabet
                //password 1 Upper, 1Lower, 1Special, 1Digit, and length8
                if (password.Length < 8)
                {
                    throw new InvalidProgramException("Password Length should be greater");
                }
            }
        }
    }
   
        
    
}
