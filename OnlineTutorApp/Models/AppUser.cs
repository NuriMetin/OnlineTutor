using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        [StringLength(75)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        [MinLength(3)]
        public string Surname { get; set; }

        [Required]
        [StringLength(75)]
        [MinLength(3)]
        public string FatherName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DataType Born { get; set; }

        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }

        public string Image { get; set; }

        public virtual ICollection<CourseUser> CoursesUsers { get; set; }
        public virtual ICollection<UserControlTestresult> UserTestResults { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<GroupUserCourse> GroupUserCourses { get; set; }
    }
}
