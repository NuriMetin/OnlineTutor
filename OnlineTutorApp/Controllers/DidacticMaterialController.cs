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
    public class DidacticMaterialController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;
        public DidacticMaterialController(AppDbContext dbContext, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> List(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            CourseVM courseViewModel = new CourseVM();
            courseViewModel.DidacticMaterials = await _dbContext.DidacticMaterials.Include(x => x.Course).Where(x => x.CourseId == id).ToListAsync();
            return View(courseViewModel);
        }

        //[Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public IActionResult Create(int id)
        {

            return View();
        }

      //  [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        public async Task<IActionResult> Create(int id, FilesViewModel fileModel)
        {
            if (!ModelState.IsValid)
            {
                return View(fileModel);
            }
            
            string path = Path.Combine(_env.WebRootPath, "didacticMaterials");
            string fileName = Guid.NewGuid().ToString() + fileModel.File.FileName;
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await fileModel.File.CopyToAsync(fileStream);
            }

            DidacticMaterial didacticMaterial = new DidacticMaterial
            {
                CourseId = id,
                Path = fileName,
                PublishDate = DateTime.Now,
                Title = fileModel.Title
            };

            await _dbContext.DidacticMaterials.AddAsync(didacticMaterial);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnCourses", "Course");
        }

        [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> OwnDidactic(int id)
        {
            CourseVM courseViewModel = new CourseVM();
            ViewBag.CourseId = id;
            courseViewModel.DidacticMaterials = await _dbContext.DidacticMaterials.Include(x => x.Course).Where(x => x.CourseId == id).ToListAsync();
            return View(courseViewModel);
        }

        [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> Delete(int id)
        {
            var didacticMaterial = await _dbContext.DidacticMaterials.FindAsync(id);
            int courseId = await _dbContext.DidacticMaterials.Where(x => x.ID == id).Include(x => x.Course).Select(x => x.Course.ID).FirstOrDefaultAsync();

            _dbContext.DidacticMaterials.Remove(didacticMaterial);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("OwnDidactic", "DidacticMaterial", new { id = courseId });
        }

    }
}