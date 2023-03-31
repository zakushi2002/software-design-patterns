using Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Mushroom : PizzaDecorator
    {
        public Mushroom(IPizza core) : base(core)
        {
        }
        public override double Cost()
        {
            return 10000 + base.Cost();
        }
        public override string getDescription()
        {
            return base.getDescription() + ", extra Mushroom";
        }
    }
}
