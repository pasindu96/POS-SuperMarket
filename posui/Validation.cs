using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posui
{
    class Validation
    {
        public static Boolean validateTextFields(String text)
        {
            if (text == "")
                return false;
            else
                return true;
            
        }
        public static Boolean validateMobile(String mobile)
        {
            Regex regex = new Regex("^([0 - 9]{ 10}$)");
            if (regex.IsMatch(mobile))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
