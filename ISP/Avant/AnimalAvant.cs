using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Avant
{
    internal class AnimalAvant
    {
        // AnimalAvant.cs:
        // AnimalAvant class represents a generic animal. It doesn't adhere to LSP as it doesn't provide specific behavior for different types of animals.
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }

        public AnimalAvant(int id, string? name, string? type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

    }
}
