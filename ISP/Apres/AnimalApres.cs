using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Apres
{
    internal class AnimalApres
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }

        public AnimalApres(int id, string? name, string? type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
