using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTutorApp.Data;
using OnlineTutorApp.Models;
using OnlineTutorApp.ViewModels;

namespace OnlineTutorApp.Controllers
{
    public class VideoController : Controller
    {
        private readonly AppDbContext _dbContext;
        public VideoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> PlayingVideo(int? id)
        {
            if (id == null)
                return NotFound();

            PlayingVideoVM videoVM = new PlayingVideoVM();

            Video video = await _dbContext.Videos
                                            .Include(x=>x.Course)
                                                .Where(x=>x.ID==id).FirstOrDefaultAsync();

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
                                                .Include(x=>x.Course)
                                                    .Where(x=>x.ID!=id && x.CourseId==video.CourseId).ToListAsync();

            videoVM.Likes = await _dbContext.LikeForVideos.Where(x=>x.Liked==true && x.VideoId==id).CountAsync();

            videoVM.DisLikes = await _dbContext.LikeForVideos.Where(x => x.Liked == false && x.VideoId == id).CountAsync();

            return View(videoVM);
        }
    }
}