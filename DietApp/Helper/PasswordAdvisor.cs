using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DietApp.Helper
{
    public class PasswordAdvisor
    {
        public bool PasswordChecker(string password)
        {
            int counter = 0;
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            string letters = @"ABCDEFGHIİJKLMNOÖPRSŞTUÜVYZ";
            string numbers = @"0123456789";
            
            foreach (char c in specialCharacters)
            {
                if (password.Contains(c))
                    counter++;
            }
            foreach (char c in letters)
            {
                if (password.Contains(c))
                    counter++;
            }
            foreach (char c in numbers)
            {
                if (password.Contains(c))
                    counter++;
            }

            if (counter >= 3)
                return true;
            else
                return false;
        }
    }
}
