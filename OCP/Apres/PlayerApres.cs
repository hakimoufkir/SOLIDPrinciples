using OCP.Apres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Apres
{
    // PlayerApres.cs:
    // In Apres, PlayerApres class represents player data only, adhering to OCP by being closed for modification. 
    // If new functionalities are needed, they can be added through inheritance or composition without modifying the existing code.
    // This class follows SRP by focusing solely on managing player attributes.

    internal class PlayerAvant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Score { get; set; }

        public float Hp { get; set; }
        public float Mana { get; set; } = 0;
        public PlayerAvant(int id, string name, float score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

      
    }
}
