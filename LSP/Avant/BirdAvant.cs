using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Avant
{
    internal class BirdAvant : IAnimalAvant
    {
        // BirdAvant.cs:
        // BirdAvant class represents a bird, implementing the IAnimalAvant interface. However, it violates LSP because it throws an exception for the Fly method, which suggests that birds cannot fly.
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public void Fly()
        {
            throw new NotImplementedException("I can fly");
        }

        public void Sleep()
        {
            Console.WriteLine("I can sleep");
        }
    }
}
