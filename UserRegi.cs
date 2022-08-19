﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserRegi
    {
        public static string USER_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string USER_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string USER_EMAIL = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public static string MOBILE_NUMBER = "^[+]{0,1}[0-9]{2}[' ']?[0-9]{10}$";
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$^&+=?!])[0-9a-zA-Z@#$^&+=?!]{8,}$";
        public bool IsValidName(string firstName)
        {
            return Regex.IsMatch(firstName, USER_FIRST_NAME);
        }
        public bool IsValidLastName(string lastName)
        {
            return Regex.IsMatch(lastName, USER_LAST_NAME);
        }
        public bool Email(string email)
        {
            return Regex.IsMatch(email, USER_EMAIL);
        }
        public bool MobileNumber(string mobileNumb)
        {
            return Regex.IsMatch(mobileNumb, MOBILE_NUMBER);
        }
        public bool Password(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }
    }
}
