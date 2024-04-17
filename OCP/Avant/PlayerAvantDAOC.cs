using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Avant
{
    // PlayerAvantDAOC.cs:
    // PlayerAvantDAOC class handles database operations, but it's also violating OCP because any change or addition in database operations will require modification of this class.
    internal class PlayerAvantDAOC
    {
        public void Save() { 
            // save to DB
        }
    }
}
