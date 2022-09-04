using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person User = new Person();

            Console.WriteLine("What is your First Name:");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name: ");
            User.LastName = Console.ReadLine();

            return User;
        }
            
    }
}
