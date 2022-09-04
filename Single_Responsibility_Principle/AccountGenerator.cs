using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            Console.WriteLine($"Your UserName is { person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
