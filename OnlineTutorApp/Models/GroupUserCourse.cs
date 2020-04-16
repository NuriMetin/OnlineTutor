using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class GroupUserCourse
    {
        public int ID { get; set; }
        
        [Required]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        [Required]
        public int RoleId { get; set; }
        public virtual GroupRole GroupRole { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
