using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Biblioteka
{
    class Validation
    {
        public static bool validEmail(string email)
        {
            string regExp = @"^([0-9a-zA-Z._-]+@[0-9a-z._-]+\.[a-z]{2,})$";
            return Regex.IsMatch(email, regExp);
        }

        public static bool validPassword(string password)
        {
            //Hasło musi zawierać przynajmniej jedną dużą literę i dwie cyfry
            string regExp = @"^(.*[0-9]+.*[A-Z]+(.*[0-9]+.*)+)|([A-Z]{1}.*[0-9]+.*[0-9]+.*)$";
            return Regex.IsMatch(password, regExp);
        }

        public static bool validPostcode(string postcode)
        {
            string regExp = @"^([0-9]{5})$|^([0-9]{2}\-[0-9]{3})$";
            return Regex.IsMatch(postcode, regExp);
        }

        public static bool validStreet(string street)
        {
            string regExp = @"^([A-Za-z]+ [0-9]+( *)*)$";
            return Regex.IsMatch(street, regExp);
        }

        public static bool validPhoneNumber(string phoneNum)
        {
            string regExp = @"^([0-9]{3,25})$";
            return Regex.IsMatch(phoneNum, regExp);
        }

        public static bool validName(string name)
        {
            string regExp = @"^([A-Za-z]+ {0,1})([A-Za-z]+ {0,1})*$";
            return Regex.IsMatch(name, regExp);
        }
    }
}
