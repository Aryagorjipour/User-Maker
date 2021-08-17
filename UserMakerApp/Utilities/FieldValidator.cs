using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMakerApp.Utilities
{
    public class FieldValidator
    {
        public static bool areFielsStuffed(string userName, string password,string repeatedPassword)
        {
            if (userName.Trim() == "" || password.Trim() == "" || repeatedPassword.Trim() == "")
            {
                return false;
            }

            return true;
        }

        public static bool isPassMatch(string password, string repeatedPassword)
        {
            if (password != repeatedPassword)
            {
                return false;
            }

            return true;
        }
    }
}
