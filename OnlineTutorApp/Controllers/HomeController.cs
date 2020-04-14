using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(AppDbContext dbContext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Courses = await _dbContext.Courses
                                                .Include(x=>x.CoursesUsers)
                                                    .Include(x=>x.Category).ToListAsync();

            homeVM.CourseUsers = await _dbContext.CoursesUsers
                                                    .Include(x=>x.Course)
                                                        .Include(x=>x.AppUser).ToListAsync();
          
            homeVM.LikeForCourses = await _dbContext.LikeForCourses
                                                        .Include(x=>x.AppUser)
                                                            .Include(x=>x.Course).ToListAsync();

            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
                ViewBag.UserId = user.Id;
            }

            catch
            {
                ViewBag.UserId = "";
            }

            return View(homeVM);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task RolesAddedAction()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
