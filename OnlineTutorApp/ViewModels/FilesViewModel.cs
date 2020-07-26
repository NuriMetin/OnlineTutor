using Microsoft.AspNetCore.Http;
using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class FilesViewModel
    {
        public IEnumerable<Video> Videos { get; set; }


        [Required]
        public string Title { get; set; }

        public string UserName { get; set; }

        [Required]
        public IFormFile File { get; set; }
    }
}
