using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    public class FirstName
    {
        public string firstName;

        public FirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string ValidateFirstName()
        {

            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(firstName, pattern))
            {
                return firstName;
            }
            else
            {
                return firstName;
            }
        }
    }
}
