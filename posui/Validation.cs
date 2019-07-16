using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
