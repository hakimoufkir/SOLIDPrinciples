using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SRP.Apres
{
    // This is my PlayerAPresDAOL.cs script:
    // PlayerApresDAOL class manages file operations, adhering to SRP by having the single responsibility of handling file interactions.

    internal class PlayerApresDAOL
    {
        public async Task SaveToFile(PlayerApres playerApres)
        {
            await File.WriteAllTextAsync($"./book-{playerApres.Name}.json", JsonSerializer.Serialize(this,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }

         ));
            
}

    }
}
