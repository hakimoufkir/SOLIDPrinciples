using OCP.Apres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Apres
{
    // PlayerAvantDAOC.cs:
    // PlayerAvantDAOC class handles database operations. It adheres to OCP by implementing the IPlayerApresDAO interface, allowing for different implementations of data access without modifying existing code.
    // New database operations can be added through new implementations of the interface, ensuring that existing code remains unchanged.
    internal class PlayerAvantDAOC : IPlayerApresDAO
    {
        public void Save(PlayerAvant playerApres)
        {
            // save to DB
        }
    }
}
