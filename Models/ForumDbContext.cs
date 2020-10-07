using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Forum.Models
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options) { }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
