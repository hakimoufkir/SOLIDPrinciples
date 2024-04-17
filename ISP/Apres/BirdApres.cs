using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Apres
{
    internal class BirdApres : IAnimalApres, IAnimalApres2
    {
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public void Sleep()
        {
            Console.WriteLine("I can sleep");
        }
    }
}
