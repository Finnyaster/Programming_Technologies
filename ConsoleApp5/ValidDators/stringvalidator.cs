using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ValidDators
{
    class stringvalidator
    {
        public static bool ValidDate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
        }
    }
}
