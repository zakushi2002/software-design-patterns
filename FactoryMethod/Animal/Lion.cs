using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    class Lion : IAnimal
    {
        public string getImage()
        {
            return "lion.jpg";
        }

        public string getName()
        {
            return "Lion";
        }
    }
}
