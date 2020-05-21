using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class DidacticMaterial
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [NotMapped]
        public IFormFile Path { get; set; }
    }
}
