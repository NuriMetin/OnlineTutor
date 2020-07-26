using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    [Authorize]
    public class SillabusController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public SillabusController(AppDbContext dbContext, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _env = env;
        }

       // [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.CourseId = id;
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        public async Task<IActionResult> Create(int id, FilesViewModel fileModel)
        {
            if (!ModelState.IsValid)
            {
                return View(fileModel);
            }
            string path = Path.Combine(_env.WebRootPath, "sillabus");
            string fileName = Guid.NewGuid().ToString() + fileModel.File.FileName;
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await fileModel.File.CopyToAsync(fileStream);
            }

            Sillabus sillabus = new Sillabus
            {
                CourseId = id,
                Path = fileName,
                PublishDate = DateTime.Now,
                Title = fileModel.Title
            };

            await _dbContext.Sillabus.AddAsync(sillabus);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnCourses", "Course");
        }

        public async Task<IActionResult> List(int id)
        {

            CourseVM courseViewModel = new CourseVM();
            courseViewModel.SillabusList = await _dbContext.Sillabus.Include(x => x.Course).Where(x => x.CourseId == id).ToListAsync();
            return View(courseViewModel);
        }

        
       // [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> OwnSillabus(int id)
        {
            ViewBag.CourseId = id;
            CourseVM courseViewModel = new CourseVM();
            courseViewModel.SillabusList = await _dbContext.Sillabus.Include(x => x.Course).Where(x => x.CourseId == id).ToListAsync();
            return View(courseViewModel);
        }

        //[Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> Delete(int id)
        {
            var sillabus = await _dbContext.Sillabus.FindAsync(id);
            int courseId = await _dbContext.Sillabus.Where(x => x.ID == id).Include(x => x.Course).Select(x => x.Course.ID).FirstOrDefaultAsync();

            _dbContext.Sillabus.Remove(sillabus);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnSillabus", "Sillabus", new { id = courseId });
        }
    }
}
