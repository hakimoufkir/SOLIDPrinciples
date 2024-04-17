using OCP.Apres;
using OCP.Avant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OCP.Apres
{
    // PlayerAvantDAOL.cs:
    // PlayerAvantDAOL class manages file operations. It also adheres to OCP by implementing the IPlayerApresDAO interface, allowing for different implementations of data access without modifying existing code.
    // New file operations can be added through new implementations of the interface, ensuring that existing code remains unchanged.

    internal class PlayerAvantDAOL : IPlayerApresDAO
    {     
        public async void Save(PlayerAvant playerApres)
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

    // By adhering to OCP:
    // - Classes become more stable as they are closed for modification but open for extension.
    // - Codebase becomes easier to maintain and extend without risking the stability of existing functionalities.
    // - New functionalities can be added through inheritance or composition without modifying existing code, promoting code reuse and scalability.