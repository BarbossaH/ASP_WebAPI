using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net918.Models
{
    public class Owner
    {
        public int Id { get; set; }
               public string FirstName { get; set; }= null!;
        public string LastName { get; set; }= null!;
        public string Gym { get; set; } = null!;
        public Country Country{ get; set; } = null!;

        public ICollection<PokemonOwner> PokemonOwners{ get; set; } = null!;
    }
}