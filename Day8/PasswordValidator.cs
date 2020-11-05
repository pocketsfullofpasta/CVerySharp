using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day8
{
    class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if(password.Length >= 8)
            {


                // + Pārbaudīt arī skaitļus un burtus
                //char.isDigit / char.isLetter
                bool isDigits = false;
                bool isLetters = false;
                foreach(char symbol in password)
                {
                    if (char.IsLetter(symbol))
                    {
                        isLetters = true;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        isDigits = true;
                    }
                    if (isLetters && isDigits)
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }
    }
}
