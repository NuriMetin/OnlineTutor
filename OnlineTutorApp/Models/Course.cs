using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Course
    {
        public int ID { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public string Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public decimal Amount { get; set; }

        public bool IsFree { get; set; }

        public int ViewCount { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<CourseUser> CoursesUsers { get; set; }
        public virtual ICollection<DidacticMaterial> DidacticMaterials { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Sillabus> Sillabus { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }
        public virtual ICollection<LikeForCourse> LikeForCourses { get; set; }
    }
}
