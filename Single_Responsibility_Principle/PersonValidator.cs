using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonValidator
    {
        public static bool Validate(Person peron)
        {
            if (string.IsNullOrWhiteSpace(peron.FirstName))
            {
                StandardMessages.DisplayValidationError("FirstName");
                return false;
            }

            if (string.IsNullOrWhiteSpace(peron.LastName))
            {
                StandardMessages.DisplayValidationError("LastName");
                return false;
            }

            return true;
        }
    }
}
