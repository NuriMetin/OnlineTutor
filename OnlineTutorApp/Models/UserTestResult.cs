using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class UserTestResult
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Required]
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public byte Result { get; set; }
    }
}
