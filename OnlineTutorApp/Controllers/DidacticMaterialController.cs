using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;

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
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.CourseId = id;

            IEnumerable<DidacticMaterial> didacticMaterials = await _dbContext.DidacticMaterials.Where(x => x.CourseId == id).ToListAsync();

            return View(didacticMaterials);
        }

    }
}