using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Apres
{
    internal class DogApres : IAnimalApres
    {
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public void Sleep()
        {
            Console.WriteLine("I can sleep");
        }
    }
}
