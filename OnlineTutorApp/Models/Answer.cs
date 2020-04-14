using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Answer
    {
        public int ID { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public bool IsTrue { get; set; }

        [Required]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
