using OCP.Apres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Apres
{
    // IPlayerApresDAO.cs:
    // This interface defines a contract for saving player data, adhering to OCP by allowing extension for different types of data access without modifying existing classes.
    internal interface IPlayerApresDAO
    {
        public void Save(PlayerAvant playerApres);
    }
}
