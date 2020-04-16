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

            var isLiked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == true && x.AppUserId == user.Id).FirstOrDefaultAsync();

            var IsDisliked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == false && x.AppUserId == user.Id).FirstOrDefaultAsync();


            if (isLiked != null)
            {
                return Json(new { status = "400" });
            }


            LikeForVideo like = new LikeForVideo
            {
                VideoId = videoId,
                Liked = true,
                AppUserId = user.Id
            };

            await _dbContext.LikeForVideos.AddAsync(like);

            if (IsDisliked != null)
            {
                _dbContext.LikeForVideos.Remove(IsDisliked);
            }

            await _dbContext.SaveChangesAsync();

            return Json(new { status = "200" });
        }

        [HttpPost]
        public async Task<IActionResult> DisLikeVideo(int videoId)
        {
            AppUser user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();

            if (user == null)
                return RedirectToAction("Login", "Account");

            var isLiked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == true && x.AppUserId == user.Id).FirstOrDefaultAsync();

            var IsDisliked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == false && x.AppUserId == user.Id).FirstOrDefaultAsync();

            if (IsDisliked != null)
            {
                return Json(new { status = 400 });
            }

            LikeForVideo dislike = new LikeForVideo
            {
                VideoId = videoId,
                Liked = false,
                AppUserId = user.Id
            };

            await _dbContext.LikeForVideos.AddAsync(dislike);

            if (isLiked != null)
            {
                _dbContext.LikeForVideos.Remove(isLiked);
            }

            await _dbContext.SaveChangesAsync();

            return Json(new { status = 200 });

        }

        public async Task<IActionResult> LoadLikes(int videoId)
        {
            int likes = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == true).CountAsync();

            int dislikes = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == false).CountAsync();

            PlayingVideoVM playingVideoVM = new PlayingVideoVM
            {
                Likes = likes,
                DisLikes = dislikes
            };

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
            if (courseId == null || courseId == 0)
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