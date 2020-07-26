using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    [Authorize]
    public class QuestionController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public QuestionController(AppDbContext dbcontext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbcontext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> QuestionList(int id)
        {
            QuestionViewModel questionView = new QuestionViewModel();
            questionView.QuizId = id;

            questionView.Questions = await _dbContext.Questions.Include(x => x.Answers).Include(x => x.Quiz).Where(x => x.Quiz.ID == id).ToListAsync();
            return View(questionView);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {
            QuestionViewModel questionViewModel = new QuestionViewModel();
            questionViewModel.Questions = await _dbContext.Questions.Include(x => x.Answers).Include(x => x.Quiz)
                                                .Where(x => x.Quiz.ID == id).OrderByDescending(x => x.AddedDate).ToListAsync();
            questionViewModel.QuizId = id;
            return View(questionViewModel);
        }
    }
}