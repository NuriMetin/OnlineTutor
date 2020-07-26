using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class QuestionViewModel
    {
        public int QuizId { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
