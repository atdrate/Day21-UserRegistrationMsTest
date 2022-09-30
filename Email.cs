using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    public class Email
    {
        public string email;

        public Email(string email)
        {
            this.email = email;
        }

        public string ValidateEmail()
        {
            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

            if (Regex.IsMatch(email, pattern))
            {
                return email;
            }
            else
            {
                return null;
            }
        }
    }
}
