using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public CourseUser CourseUser { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
