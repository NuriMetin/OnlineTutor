using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class CourseUser
    {
        public int ID { get; set; }

        [Required]
        public bool IsAuthor { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
