using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class HomeVM
    {
        public Course Course { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseUser> CourseUsers { get; set; }
        public IEnumerable<LikeForCourse> LikeForCourses { get; set; }
    }
}
