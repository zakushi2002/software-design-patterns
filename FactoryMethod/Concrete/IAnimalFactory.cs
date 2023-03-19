using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
