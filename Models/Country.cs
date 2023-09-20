using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net918.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Owner> Owners{ get; set;} = null!;
    }
}