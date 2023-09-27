using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp100
{
    class cEployee : IEmployee
    {
       public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Concatinate()
        {
            return FirstName + ' ' + LastName;

        }
    }
}
