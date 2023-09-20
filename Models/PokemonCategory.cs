using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net918.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }= null!;
        public Category Category { get; set; }= null!;
    }
}