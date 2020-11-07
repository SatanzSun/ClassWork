using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length >= 8)
            {
                bool digits = false;
                bool letters = false;
                foreach (char symbol in password)
                {
                    if (char.IsLetter(symbol))
                    {
                        letters = true;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        digits = true;
                    }
                    if (letters && digits)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
