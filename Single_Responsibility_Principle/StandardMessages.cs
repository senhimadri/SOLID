using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class StandardMessages
    {
        public  static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To my Application.");
        }

        public static void EndAppliaction()
        {
            Console.WriteLine("Press Enter to close....");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string FildName)
        {
            Console.WriteLine($"You didn't give us a valid {FildName}.");
        }
    } 
}
