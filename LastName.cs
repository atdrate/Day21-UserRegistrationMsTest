using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    public class LastName
    {
        public string lastName;

        public LastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string ValidateLastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                return lastName;
            }
            else
            {
                return null;
            }
        }
    }
}
