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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System.Security.Cryptography.X509Certificates;

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

        //[Authorize]
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
        //[Authorize]
        public async Task<IActionResult> Create(CourseVM courseVM)
        {
            courseVM.Categories = await _dbContext.Categories.ToListAsync();
            Course course = new Course();
            var user = await _dbContext.Users.SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);

            if (courseVM.Course.IsFree != true)
            {
                if (courseVM.Course.Amount == 0)
                {
                    ModelState.AddModelError("Course.Amount", "Boş ola bilməz!!!");
                    return View(courseVM);
                }
                course.Amount = courseVM.Course.Amount;
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

            string image = await courseVM.Course.Photo.SaveAsync(_env.WebRootPath, "images", "courses");

            course.CategoryId = courseVM.CategoryId;
            course.Content = courseVM.Course.Content;
            course.IsFree = courseVM.Course.IsFree;
            course.Image = image;
            course.PublishDate = DateTime.Now;
            course.Title = courseVM.Course.Title;

            await _dbContext.AddAsync(course);

            CourseUser courseUser = new CourseUser
            {
                AppUserId = user.Id,
                CourseId = course.ID,
                IsAuthor = true
            };

            await _dbContext.AddAsync(courseUser);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(OwnCourses));
        }

        [Authorize]
        public async Task<IActionResult> OwnCourses()
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);

            CourseVM courseVM = new CourseVM
            {
                CourseUsers = await _dbContext.CoursesUsers
                                                 .Include(x => x.Course)
                                                    .Include(x => x.Course.Category)
                                                        .Include(x => x.AppUser)
                                                            .Include(x => x.Course.DidacticMaterials)
                                                                .Include(x => x.Course.Videos)
                                                                    .Include(x => x.Course.Quizzes)
                                                                        .Where(x => x.AppUserId == user.Id).ToListAsync(),

                LikeForCourses = await _dbContext.LikeForCourses.Include(x => x.Course).ToListAsync()
            };



            return View(courseVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course course = await _dbContext.Courses
                                       .Include(x => x.Videos)
                                            .Include(x => x.DidacticMaterials)
                                                .Include(x => x.Quizzes)
                                                    .Include(x => x.LikeForCourses)
                                                       .Where(x => x.ID == id)
                                                           .FirstOrDefaultAsync();

            if (course == null)
            {
                return NotFound();
            }

            

            RemoveFile(_env.WebRootPath, "images", "courses", course.Image);

            foreach (var video in course.Videos)
            {
                if (video != null)
                {
                    RemoveFile(_env.WebRootPath, "videos", video.Path);
                }
                
            }

            foreach (var didacticMaterial in course.DidacticMaterials)
            {
                if (didacticMaterial != null)
                {
                    RemoveFile(_env.WebRootPath, "didacticMaterials", didacticMaterial.Name);
                }
            }

            foreach (var quiz in course.Quizzes)
            {
                if (quiz != null)
                {
                    RemoveFile(_env.WebRootPath, "quizzes", quiz.Title);
                }
            }

            _dbContext.Courses.Remove(course);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(OwnCourses));
        }
    }
}