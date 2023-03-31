using Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Squid : PizzaDecorator
    {
        public Squid(IPizza core) : base(core)
        {
        }
        public override double Cost()
        {
            return 20000d + base.Cost();
        }
        public override string getDescription()
        {
            return base.getDescription() + ", extra Squid";
        }
    }
}
