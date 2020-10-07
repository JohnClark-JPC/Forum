using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Forum.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ForumDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ForumDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new Post
                    {
                        TopicID = 1,
                        ForumID = 1,
                        UserName = "Anonymous",
                        PostTime = DateTime.Now
                    },
                    new Post
                    {
                        TopicID = 1,
                        ForumID =2,
                        UserName = "Anonymous",
                        PostTime = DateTime.Now,
                    },
                    new Post
                    {
                        TopicID = 1,
                        ForumID = 3,
                        UserName = "Anonymous",
                        PostTime = DateTime.Now,
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
