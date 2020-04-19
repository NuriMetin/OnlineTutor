using System;
using System.Collections.Generic;
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
    public class AjaxController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        public AjaxController(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> LikeVideo(int videoId)
        {
            AppUser user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();

            LikeForVideo likeForVideoFromDb = await _dbContext.LikeForVideos.Where(x => x.AppUserId == user.Id && x.VideoId == videoId).FirstOrDefaultAsync();

            if (likeForVideoFromDb != null)
            {
                if (likeForVideoFromDb.Liked == false)
                {
                    likeForVideoFromDb.Liked = true;
                    await _dbContext.SaveChangesAsync();
                    return Json(new { status = "200" });
                }
            }

            else
            {
                LikeForVideo likeForVideo = new LikeForVideo
                {
                    AppUserId = user.Id,
                    VideoId = videoId,
                    Liked = true
                };
                await _dbContext.LikeForVideos.AddAsync(likeForVideo);
                await _dbContext.SaveChangesAsync();
                return Json(new { status = "200" });
            }

            return Json(new { status = "400" });
        }

        [HttpPost]
        public async Task<IActionResult> DisLikeVideo(int videoId)
        {
            AppUser user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();

            LikeForVideo likeForVideoFromDb = await _dbContext.LikeForVideos.Where(x => x.AppUserId == user.Id && x.VideoId == videoId).FirstOrDefaultAsync();

            if (likeForVideoFromDb != null)
            {
                if (likeForVideoFromDb.Liked == true)
                {
                    likeForVideoFromDb.Liked = false;
                    await _dbContext.SaveChangesAsync();
                    return Json(new { status = "200" });
                }
            }

            else
            {
                LikeForVideo likeForVideo = new LikeForVideo
                {
                    AppUserId = user.Id,
                    VideoId = videoId,
                    Liked = false
                };
                await _dbContext.LikeForVideos.AddAsync(likeForVideo);
                await _dbContext.SaveChangesAsync();
                return Json(new { status = "200" });
            }

            return Json(new { status = "400" });

        }

        public async Task<IActionResult> LoadLikes(int videoId)
        {
            string userId = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Id;
            ViewBag.UserId = userId;
            int userLikeCount = 0;
            int userDisLikeCount = 0;
            string likeStyle = "far";
            string disLikeStyle = "far";

            PlayingVideoVM playingVideoVM = new PlayingVideoVM();

            playingVideoVM.LikesForVideos = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId).ToListAsync();

            foreach (var item in playingVideoVM.LikesForVideos)
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

            return PartialView("_LoadLikesPartial", playingVideoVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(string commentVal, int videoId)
        {
            string userId = "";
            try
            {
                userId = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Id;
            }
            catch
            {
                return RedirectToAction("Login", "Account");
            }
            Comment comment = new Comment
            {
                CommentDate = DateTime.Now,
                CommentText = commentVal,
                VideoId = videoId,
                AppUserId = userId
            };

            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();

            return Json(new { status = "200" });
        }

        public async Task<IActionResult> LoadComments(int? videoId)
        {
            if (videoId == null)
                return NotFound();

            PlayingVideoVM videoVM = new PlayingVideoVM
            {
                Comments = await _dbContext.Comments
                                                .Include(x => x.AppUser)
                                                    .Where(x => x.VideoId == videoId)
                                                        .OrderByDescending(x => x.CommentDate).ToListAsync()
            };

            return PartialView("_LoadCommentsPartial", videoVM);
        }

        [HttpPost]
        public async Task<IActionResult> LikeCourse(int courseId)
        {
            if (courseId == 0)
                return NotFound();

            string userId = "";
            string heartStyle = "";

            try
            {
                userId = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Id;
            }

            catch
            {
                return RedirectToAction("Login", "Account");
            }

            LikeForCourse likeForCourseFromDb = _dbContext.LikeForCourses.Where(x => x.CourseId == courseId && x.AppUserId == userId).FirstOrDefault();

            if (likeForCourseFromDb == null)
            {
                LikeForCourse likeForCourse = new LikeForCourse
                {
                    AppUserId = userId,
                    CourseId = courseId,
                    Liked = true
                };

                _dbContext.Add(likeForCourse);
                _dbContext.SaveChanges();

                heartStyle = "fas";
            }

            else
            {
                _dbContext.Remove(likeForCourseFromDb);
                _dbContext.SaveChanges();

                heartStyle = "far";
            }

            int likeCount = _dbContext.LikeForCourses.Where(x => x.CourseId == courseId).Count();

            return Json(new { status = 200, count = likeCount, heart = heartStyle });
        }

    }
}