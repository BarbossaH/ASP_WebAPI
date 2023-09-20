using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net918.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; }= null!;

        public ICollection<Review> Reviews { get; set; } = null!;
    }
}