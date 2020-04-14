using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Gender
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
