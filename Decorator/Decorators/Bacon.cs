using Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Bacon : PizzaDecorator
    {
        public Bacon(IPizza core) : base(core)
        {
        }
        public override double Cost()
        {
            return 25000d + base.Cost();
        }
    }
}
