using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Rewrite.Internal;
using OnlineTutorApp.Extensions;
using Microsoft.AspNetCore.Hosting;

namespace OnlineTutorApp.Controllers
{
    public class VideoController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;
        public VideoController(AppDbContext dbContext, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _env = env;
        }

        public async Task<IActionResult> Create()
        {
            //if (courseId == null)
            //{
            //    return NotFound();
            //}

            //ViewBag.CourseId = courseId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Video video)
        {
            if (video.VideoPath != null)
            {
                if (!video.VideoPath.IsVideo())
                {
                    ModelState.AddModelError("Photo", "Fayl video tipində olmalıdır!!!");
                    return View(video);
                }
            }

            string path = await video.VideoPath.SaveAsync(_env.WebRootPath, "videos");
            return RedirectToAction("List", "Video", new { courseId = video.CourseId });
        }

        public async Task<IActionResult> PlayingVideo(int? id)
        {
            if (id == null)
                return NotFound();

            PlayingVideoVM videoVM = new PlayingVideoVM();

            string userId = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Id;
            ViewBag.UserId = userId;
            int userLikeCount = 0;
            int userDisLikeCount = 0;
            string likeStyle = "far";
            string disLikeStyle = "far";

            Video video = await _dbContext.Videos
                                            .Include(x => x.Course)
                                                .Where(x => x.ID == id).FirstOrDefaultAsync();

            videoVM.Video = video;

            try
            {
                videoVM.Comments = await _dbContext.Comments
                                                  .Include(x => x.AppUser)
                                                      .Include(x => x.Video)
                                                          .Where(x => x.VideoId == id)
                                                              .OrderByDescending(x => x.CommentDate).ToListAsync();
            }
            catch
            {
                videoVM.Comments = null;
            }

            videoVM.Videos = await _dbContext.Videos
                                                .Include(x => x.Course)
                                                    .Where(x => x.ID != id && x.CourseId == video.CourseId).ToListAsync();


            videoVM.LikesForVideos = await _dbContext.LikeForVideos.Where(x => x.VideoId == id).ToListAsync();

            foreach (var item in videoVM.LikesForVideos)
            {
                if (item.Liked == true && item.AppUserId == userId)
                {
                    userLikeCount += 1;
                }
                if (item.Liked == false && item.AppUserId == userId)
                {
                    userDisLikeCount += 1;
                }
            }

            if (userLikeCount > 0)
            {
                likeStyle = "fas";
            }

            if (userDisLikeCount > 0)
            {
                disLikeStyle = "fas";
            }
            ViewBag.LikeStyle = likeStyle;
            ViewBag.DisLikeStyle = disLikeStyle;

            return View(videoVM);
        }

        [HttpPost]
        public async Task<IActionResult> ViewCount(int? id)
        {
            if (id == null)
                return NotFound();

            Video video = await _dbContext.Videos.FindAsync(id);

            if (video == null)
                return NotFound();

            int count = video.ViewCount + 1;

            video.ViewCount = count;

            _dbContext.SaveChanges();

            return RedirectToAction("PlayingVideo", "Video", new { id = id });
        }


        public async Task<IActionResult> List(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.CourseId = id;

            IEnumerable<Video> videos = await _dbContext.Videos
                                                            .Include(x=>x.LikeForVideos)
                                                                .Include(x=>x.Comments)
                                                                    .Where(x=>x.CourseId==id).ToListAsync();

            return View(videos);
        }
    }
}