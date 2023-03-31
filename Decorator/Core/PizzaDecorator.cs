using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Core
{
    public abstract class PizzaDecorator : IPizza
    {
        private IPizza core_pizza;
        // protected here to avoid other classes implementing
        protected PizzaDecorator(IPizza core)
        {
            core_pizza = core;
        }
        // Cho phép các class kế thừa có thể override

        public virtual double Cost()
        {
            return core_pizza.Cost();
        }

        public virtual string getDescription()
        {
            return core_pizza.getDescription();
        }
    }
}
