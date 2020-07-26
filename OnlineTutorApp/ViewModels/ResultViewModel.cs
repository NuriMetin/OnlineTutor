using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class ResultViewModel
    {
        public int ID { get; set; }
        public string Username { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public byte Result { get; set; }
        public string Quiz { get; set; }
    }
}
