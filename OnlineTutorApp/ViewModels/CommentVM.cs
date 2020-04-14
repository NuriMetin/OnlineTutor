using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class CommentVM
    {
        [Required]
        public string CommentText { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }

        public int CommentCount { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
