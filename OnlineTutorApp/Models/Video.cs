using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Models
{
    public class Video
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Path { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }

        public int ViewCount { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<LikeForVideo> LikeForVideos { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
