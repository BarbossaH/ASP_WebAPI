using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net918.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<PokemonCategory> PokemonCategories { get; set; } = null!;
    }
}