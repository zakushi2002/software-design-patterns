using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    class Horse : IAnimal
    {
        public string getImage()
        {
            return "horse.jpg";
        }

        public string getName()
        {
            return "Horse";
        }
    }
}
