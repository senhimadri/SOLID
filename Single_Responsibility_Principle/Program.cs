using System;
using System.Dynamic;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Welcome Nessage Part--------------------------------------------

            //Console.WriteLine("Welcome To my Application.");

            StandardMessages.WelcomeMessage();
            //-----------------------------000-------------------------------------------------------------


            //----------------------------Data Capture ----------------------------------------------------
            //Peron User = new Peron();

            //Console.WriteLine("What is your First Name:");
            //User.FirstName = Console.ReadLine();

            //Console.WriteLine("What is your Last Name: ");
            //User.LastName = Console.ReadLine();

            Person User = PersonDataCapture.Capture();

            //--------------------------000-----------------------------------------------------------------


            //--------------------------- Data Validation --------------------------------------------------
            //if (string.IsNullOrWhiteSpace(User.FirstName))
            //{
            //    Console.WriteLine("You didn't give us a valid first name.");
            //    //Console.ReadLine();
            //    StandardMessages.EndAppliaction();
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(User.LastName))
            //{
            //    Console.WriteLine("You didn't give us a valid Last name.");
            //    //Console.ReadLine();
            //    StandardMessages.EndAppliaction();
            //    return;
            //}
            bool isUserValid = PersonValidator.Validate(User);
            if (!isUserValid)
            {
                StandardMessages.EndAppliaction();
                return;
            }

            //---------------------------000-----------------------------------------------------------------

            //----------------------------------Account Create ----------------------------------------------
            //Console.WriteLine($"Your UserName is {User.FirstName.Substring(0,1)}{User.LastName}");

            AccountGenerator.CreateAccount(User);

            //--------------------------------------000----------------------------------------------------


            //-----------------------------------End Application
            //Console.ReadLine();

            StandardMessages.EndAppliaction();
            //------------------------------------000--------------------------------------------------------
        }
    }
}
