using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Comment
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }
    }
}
