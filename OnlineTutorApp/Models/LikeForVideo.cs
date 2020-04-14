using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class LikeForVideo
    {
        [Key]
        public string ID { get; set; }

        public bool Liked { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }
    }
}
