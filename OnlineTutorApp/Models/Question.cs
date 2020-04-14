using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Question
    {
        public int ID { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
