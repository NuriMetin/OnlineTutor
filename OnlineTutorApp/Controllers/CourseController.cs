using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _dbContext;
        public CourseController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
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
                                                    .Include(x=>x.Course)
                                                        .Include(x=>x.AppUser)
                                                            .Where(x=>x.CourseId==id).FirstOrDefaultAsync();

            courseVM.Videos = await _dbContext.Videos
                                                .Include(x=>x.Course)
                                                    .Include(x=>x.LikeForVideos)
                                                        .Where(x=>x.CourseId==id).ToListAsync();

            if (courseVM == null)
                return NotFound();

            return View(courseVM);
        }

        public IActionResult PlayingVideo()
        {
            return View();
        }
    }
}