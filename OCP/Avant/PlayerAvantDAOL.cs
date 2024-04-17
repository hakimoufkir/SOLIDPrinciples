using OCP.Apres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OCP.Avant
{
    // PlayerAvantDAOL.cs:
    // PlayerAvantDAOL class handles file operations, but similar to PlayerAvantDAOC, it violates OCP as any change or addition in file operations will require modification of this class.

    internal class PlayerAvantDAOL
    {
        public async Task Save(PlayerAvant playerAvant)
        {
            await File.WriteAllTextAsync($"./book-{playerAvant.Name}.json", JsonSerializer.Serialize(this,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }

         ));
            
}

    }
}
