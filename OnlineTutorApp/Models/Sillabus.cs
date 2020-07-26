
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Sillabus
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        public string Path { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
