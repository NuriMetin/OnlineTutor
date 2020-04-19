using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using static OnlineTutorApp.Extensions.IFormFileExtension;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHostingEnvironment _env;

        public CourseController(AppDbContext dbContext, UserManager<AppUser> userManager, IHostingEnvironment env, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _env = env;
        }
        public async Task<IActionResult> SingleCourse(int? id)
        {
            if (id == null)
                return NotFound();

            CourseVM courseVM = new CourseVM();
            courseVM.Course = await _dbContext.Courses
                                                 .Where(x => x.ID == id)
                                                     .Include(x => x.Category)
                                                        .Include(x => x.Sillabus)
                                                            .Include(x => x.Videos)
                                                                .Include(x => x.Quizzes)
                                                                    .Include(x => x.CoursesUsers)
                                                                        .Include(x => x.DidacticMaterials)
                                                                            .FirstOrDefaultAsync();

            courseVM.CourseUser = await _dbContext.CoursesUsers
                                                    .Include(x => x.Course)
                                                        .Include(x => x.AppUser)
                                                            .Where(x => x.CourseId == id).FirstOrDefaultAsync();

            courseVM.Videos = await _dbContext.Videos
                                                .Include(x => x.Course)
                                                    .Include(x => x.LikeForVideos)
                                                        .Where(x => x.CourseId == id).ToListAsync();

            if (courseVM == null)
                return NotFound();

            return View(courseVM);
        }


        public async Task<IActionResult> Create()
        {
            CourseVM courseVM = new CourseVM
            {
                Categories = await _dbContext.Categories.ToListAsync()
            };
            return View(courseVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseVM courseVM)
        {
            courseVM.Categories = await _dbContext.Categories.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View(courseVM);
            }

            if (courseVM.Course.IsFree != true)
            {
                if (courseVM.Course.Amount == 0 || courseVM.Course.Amount==null)
                {
                    ModelState.AddModelError("Course.Amount", "Boş ola bilməz!!!");
                    return View(courseVM);
                }
            }

            if (courseVM.Course.Photo == null)
            {
                ModelState.AddModelError("Course.Photo", "Boş ola bilməz!!!");
                return View(courseVM);
            }

            if (!courseVM.Course.Photo.IsImage())
            {
                ModelState.AddModelError("Course.Photo", "Fayl şəkil tipində olmalıdır!!!");
                return View(courseVM);
            }
           // string image = await courseVM.Course.Photo.SaveAsync(_env.WebRootPath, "images", "courses");



            return Content("sfdbs hbc");
        }
    }
}