using Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Sausage : PizzaDecorator
    {
        public Sausage(IPizza core) : base(core)
        {
        }
        public override double Cost()
        {
            return 15000d + base.Cost();
        }
    }
}
