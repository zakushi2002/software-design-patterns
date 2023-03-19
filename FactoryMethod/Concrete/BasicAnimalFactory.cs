using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    class BasicAnimalFactory : IAnimalFactory
    {
        private int index = 0;
        private int type;

        public BasicAnimalFactory(int type)
        {
            this.type = type;
        }

        public IAnimal createAnimal()
        {
            if (type == 0)
            {
                return new Lion();
            }
            else if (type == 1)
            {
                return new Horse();
            }
            else if (type == 2)
            {
                return new Panda();
            }
            else
            {
                return null;
            }
        }

        public IAnimal createAnimalInOrder()
        {
            if (index == 0)
            {
                index++;
                return new Lion();
            }
            if (index == 1)
            {
                index++;
                return new Horse();
            }
            if (index == 2)
            {
                index = 0;
                return new Panda();
            }
            return null;
        }
    }
}
