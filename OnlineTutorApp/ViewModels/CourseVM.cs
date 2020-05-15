using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseUser> CourseUsers { get; set; }
        public IEnumerable<LikeForCourse> LikeForCourses { get; set; }
        public CourseUser CourseUser { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public int LikeCount { get; set; }
        public int CategoryId { get; set; }
    }
}
