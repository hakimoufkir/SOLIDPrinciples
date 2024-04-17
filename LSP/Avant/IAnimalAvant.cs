using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Avant
{
    // IAnimalAvant.cs:
    // IAnimalAvant interface defines common behaviors for animals. However, it's not adhering to LSP because it includes the Fly method, which is not applicable to all animals.
    internal interface IAnimalAvant
    {
        void Eat();
        void Sleep();

        void Fly();

    }
}
