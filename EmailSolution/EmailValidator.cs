using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmailSolution
{
    public class EmailValidator
    {

        public static string IsValidEmail(string email)
        {
            if (email == "") { return "email is invalid"; }

            if (!email.Contains("@")) { return "email is invalid"; }

            if (!email.Contains(".")) { return "email is invalid"; }

            if (email.Contains(" ")) { return "email is invalid"; }

            if (email.Split('@')[0].Length < 1) { return "email is invalid"; }

            if (email.Split('@','.')[1].Length < 3) { return "email is invalid"; }

            if (email.Split('@', '.')[1].Length > 100) { return "email is invalid"; }

            if (!char.IsLetter(email.First())) { return "email is invalid"; }

            if (!char.IsLetter(email.Last())) { return "email is invalid"; }

            else { return "email is valid"; }

        }
    }
}
