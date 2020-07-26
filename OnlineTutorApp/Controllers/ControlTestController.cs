using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    public class ControlTestController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ControlTestController(AppDbContext dbcontext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbcontext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Submit(IFormCollection iformCollection, int qiuzId)
        {
            byte score = 0;
            string[] questionIds = iformCollection["questionId"];
            foreach (var questionId in questionIds)
            {
                var correctAnswerId = await _dbContext.Answers.Include(x => x.Question)
                           .Where(x => x.IsTrue == true && x.Question.ID == int.Parse(questionId)).Select(x => x.ID).FirstOrDefaultAsync();
                if (correctAnswerId == Convert.ToInt32(iformCollection["question_" + questionId]))
                {
                    score++;
                }
            }

            try
            {
                AppUser user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
                UserControlTestresult testResult = new UserControlTestresult
                {
                    AppUserId = user.Id,
                    Date = DateTime.Now,
                    QuizId = qiuzId,
                    Result = score
                };

                await _dbContext.UserControlTestresults.AddAsync(testResult);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Results));
            }

            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> UsersResults(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }


            var datas = await _dbContext.UserControlTestresults
                .Include(x => x.Quiz)
                .Include(x => x.AppUser)
                .Where(x => x.Quiz.ID == id)
                .Select(x => new ResultViewModel
                {
                    Username = x.AppUser.Name + " " + x.AppUser.Surname,
                    Date = x.Date,
                    Result = x.Result
                }).OrderByDescending(x => x.Result).ToListAsync();
            return View(datas);
        }

        [Authorize]
        public async Task<IActionResult> Results()
        {
            var user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            var data = await _dbContext.UserControlTestresults
                .Include(x => x.AppUser)
                .Include(x => x.Quiz)
                .Where(x => x.AppUser.Id == user.Id)
                .Select(x => new ResultViewModel
                {
                    Quiz = x.Quiz.Title,
                    Date = x.Date,
                    Result = x.Result
                }).OrderByDescending(x => x.Date).ToListAsync();
            return View(data);
        }
    }
}