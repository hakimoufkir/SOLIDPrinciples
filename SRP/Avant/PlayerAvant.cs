using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading.Tasks;
using SRP.Apres;

namespace SRP.Avant
{
    // Avant:
    // This is my PlayerAvant.cs script:
    // In Avant, the PlayerAvant class violates SRP by combining player data and both file and database saving responsibilities within a single class.
    internal class PlayerAvant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Score { get; set; }

        public float Hp {  get; set; }
        public float Mana { get; set; } = 0;
        public PlayerAvant(int Id, string Name, float Score) {
            this.Id = Id;
            this.Name = Name;
            this.Score = Score;
        }

        public async Task SaveToFile(PlayerApres playerApres)
        {
            await File.WriteAllTextAsync($"./book-{playerApres.Name}.json", JsonSerializer.Serialize(this,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }

         ));
        }       
        public void SaveToDB() { 
        
            // save to db
        }







       
    }
}
