using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Avant
{
    internal class DogAvant : IAnimalAvant
    {
        // DogAvant.cs:
        // DogAvant class represents a dog, also implementing the IAnimalAvant interface. Similarly, it violates LSP by throwing an exception for the Fly method, indicating that dogs cannot fly.
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public void Fly()
        {
            throw new NotImplementedException("I cant fly ?_?");
        }

        public void Sleep()
        {
            Console.WriteLine("I can sleep");
        }
    }
}
