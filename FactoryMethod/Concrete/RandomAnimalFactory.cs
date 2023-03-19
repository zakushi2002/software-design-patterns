using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0,3);
            if (type == 0)
            {
                return new Lion();
            }
            else if (type == 1)
            {
                return new Horse();
            }
            else
            {
                return new Panda();
            }
        }
    }
}
