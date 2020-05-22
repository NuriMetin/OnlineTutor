using OnlineTutorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.Extensions
{
    public static class RemoveListExtension
    {
        private static readonly AppDbContext _dbContext;

        public static void RemoveFile<T>(List<T> files)
        {
            foreach (var file in files)
            {
                _dbContext.Remove(file);
            }
        }
    }
}
