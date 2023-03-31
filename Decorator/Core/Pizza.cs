using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Core
{
    class Pizza : IPizza
    {

        public double Cost()
        {
            return 49000d;
        }

        public string getDescription()
        {
            return "Pizza";
        }
    }
}
