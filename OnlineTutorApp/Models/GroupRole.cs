﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class GroupRole
    {
        public int ID { get; set; }

        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<GroupUserCourse> GroupUserCourses { get; set; }
    }
}
