using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class DidacticMaterial
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public bool IsFree { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
