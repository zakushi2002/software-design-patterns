using Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Tomato : PizzaDecorator
    {
        public Tomato(IPizza core) : base(core)
        {
        }
        public override double Cost()
        {
            return 5000d + base.Cost();
        }
        public override string getDescription()
        {
            return base.getDescription() + ", extra Tomato";
        }
    }
}
