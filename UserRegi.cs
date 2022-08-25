using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserRegi
    {
        
        public static string USER_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string USER_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string USER_EMAIL = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILE_NUMBER = "^[+]{0,1}[0-9]{2}[' ']?[0-9]{10}$";
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$^&+=?!])[0-9a-zA-Z@#$^&+=?!]{8,}$";

        List<string> userData = new List<string> (new string[] { USER_FIRST_NAME, USER_LAST_NAME, USER_EMAIL, MOBILE_NUMBER, PASSWORD });
        //List<string> list = new List<string> ();
        public bool FirstName(string firstName) => (Regex.IsMatch(firstName, USER_FIRST_NAME)); 
        
        public bool LastName(string lastName) => (Regex.IsMatch (lastName, USER_LAST_NAME));

        public bool Email(string email) => (Regex.IsMatch(email, USER_EMAIL));
        
        public bool MobileNumber(string mobileNumb) => (Regex.IsMatch(mobileNumb, MOBILE_NUMBER));

        public bool Password(string password) => (Regex.IsMatch(password, PASSWORD));
        
    }
}
