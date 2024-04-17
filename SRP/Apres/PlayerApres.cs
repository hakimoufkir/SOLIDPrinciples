using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Apres
{
    // Apres:
    // This is my PlayerApres.cs script:
    // In Apres, PlayerApres class represents player data only, adhering to SRP by focusing solely on one responsibility: managing player attributes.

    internal class PlayerApres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Score { get; set; }

        public float Hp { get; set; }
        public float Mana { get; set; } = 0;
        public PlayerApres(int id, string name, float score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

      
    }
}
