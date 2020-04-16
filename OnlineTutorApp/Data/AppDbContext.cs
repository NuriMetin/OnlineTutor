using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineTutorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<CourseUser> CoursesUsers { get; set; }
        public DbSet<DidacticMaterial> DidacticMaterials { get; set; }
        public DbSet<LikeForVideo> LikeForVideos { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Sillabus> Sillabus { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserTestResult> UserTestResults { get; set; }
        public DbSet<LikeForCourse> LikeForCourses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUserCourse> GroupsUsersCourses { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Magistr" },
                new Category { ID = 2, Name = "Bakalavr" },
                new Category { ID = 3, Name = "Abituriyent" }
                );

            builder.Entity<Course>().HasData(
                new Course { ID = 1, CategoryId = 1, Image = "img1.jpg", Title = "Product 1", Amount = 56, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Course { ID = 2, CategoryId = 2, Image = "img2.jpg", Title = "Product 2", Amount = 48, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Course { ID = 3, CategoryId = 2, Image = "img3.jpg", Title = "Product 3", Amount = 75, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Course { ID = 4, CategoryId = 3, Image = "img4.jpg", Title = "Product 4", Amount = 45, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Course { ID = 5, CategoryId = 1, Image = "img5.jpg", Title = "Product 5", Amount = 37, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Course { ID = 6, CategoryId = 3, Image = "img6.jpg", Title = "Product 6", Amount = 89, IsFree = true, Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." }
                );

            builder.Entity<Gender>().HasData(
                new Gender { ID = 1, Name = "Kişi" },
                new Gender { ID = 2, Name = "Qadın" },
                new Gender { ID = 3, Name = "Başqa" }
                );

            builder.Entity<Group>().HasData(
                new Group { ID = 1, Name = "P405" },
                new Group { ID = 2, Name = "686a2" },
                new Group { ID = 3, Name = "P407" },
                new Group { ID = 4, Name = "P403" }
                );
        }
    }
}
