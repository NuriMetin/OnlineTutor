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

namespace OnlineTutorApp.Controllers
{
    public class QuizController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public QuizController(AppDbContext dbcontext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbcontext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> QuizList(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ViewBag.IsAuthor = false;
            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
                string CourseUserId = _dbContext.CoursesUsers.Where(x => x.CourseId == id).Select(x => x.AppUserId).FirstOrDefaultAsync().ToString();
                if (CourseUserId == user.Id)
                {
                    ViewBag.IsAuthor = true;
                }
            }
            catch
            {
                ViewBag.IsAuthor = false;
            }
            ViewBag.CourseId = id;
            var datas = await _dbContext.Quizzes.Where(x => x.Course.ID == id).Include(x => x.Questions).Include(x => x.Course).ToListAsync();
            return View(datas);
        }

       // [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> OwnQuizzes(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ViewBag.CourseId = id;
            var datas = await _dbContext.Quizzes.Where(x => x.Course.ID == id).Include(x => x.Questions).Include(x => x.Course).ToListAsync();
            return View(datas);
        }

        //[Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {

            return View();
        }

        // [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        public async Task<IActionResult> Create(int id, Quiz quizModel)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Quiz quiz = new Quiz
            {
                CourseId = id,
                Title = quizModel.Title
            };

            await _dbContext.Quizzes.AddAsync(quiz);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnQuizzes", "Quiz", new { id = id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var quiz = await _dbContext.Quizzes.FindAsync(id);
            int courseId = await _dbContext.Quizzes.Where(x => x.ID == id).Include(x => x.Course).Select(x => x.Course.ID).FirstOrDefaultAsync();

            _dbContext.Quizzes.Remove(quiz);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnQuizzes", "Quiz", new { id = courseId });
        }

        public async Task<IActionResult> AllQuizzes()
        {
            var datas = await _dbContext.Quizzes.Include(x => x.Questions).Include(x => x.Course).ToListAsync();
            return View(datas);
        }


    }
}