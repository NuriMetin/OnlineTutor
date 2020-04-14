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
        public async Task<IActionResult> Like(int videoId)
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
        public async Task<IActionResult> DisLike(int videoId)
        {
            AppUser user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            var isLiked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == true && x.AppUserId == user.Id).FirstOrDefaultAsync();

            var IsDisliked = await _dbContext.LikeForVideos.Where(x => x.VideoId == videoId && x.Liked == false && x.AppUserId == user.Id).FirstOrDefaultAsync();

            if (IsDisliked != null)
            {
                return Json(new { status = "400" });
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

            return Json(new { status = "200" });

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
    }
}