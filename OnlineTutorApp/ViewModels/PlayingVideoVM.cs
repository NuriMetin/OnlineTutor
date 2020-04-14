using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class PlayingVideoVM
    {
        public List<Video> Videos { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Video Video { get; set; }
    }
}
