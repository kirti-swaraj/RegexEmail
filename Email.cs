using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexEmail
{
    class Email
    {
        public static void validateEmail()
        {
            string emailPattern = "^[a-zA-Z]+([+-_.][a-zA-Z]+)*[@][a-zA-Z]+[.][a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Please enter email:");
            string email = Console.ReadLine();
            if (regex.IsMatch(email))
                Console.WriteLine("It is a valid email");
            else
                Console.WriteLine("It is not a valid email");

        }
    }
}