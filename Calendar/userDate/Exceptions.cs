using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userDate
{
    class WrongValue: ApplicationException 
    {
        public WrongValue() {
        }

        public WrongValue(string message):base(message)
        {
        }

    }


}
