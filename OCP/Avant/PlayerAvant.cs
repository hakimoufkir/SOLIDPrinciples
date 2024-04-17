using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Avant
{
    // PlayerAvant.cs:
    // In Avant, PlayerAvant class represents player data, but it violates OCP because it may need modification for adding new functionalities.
    // If new functionalities require changes to this class, it violates OCP as it's open for modification.

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
